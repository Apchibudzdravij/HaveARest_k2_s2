using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.RegularExpressions;
using System.IO;

namespace OOP_Lab_3
{
    partial class Form_menu
    {
        private void ChangeEverything()
        {
            if (mainlabel.Visible == true)
            {
                toolStrip1.Visible = true;
                res_toolStrip.Visible = true;
                log_res_tool.Visible = true;
                mainlabel.Visible = false;
                queryBox.Visible = false;
                panel_find.Visible = false;
                panel_sort.Visible = false;
                button_find_res.Visible = false;
                button_sort_res.Visible = false;
                metainfo.Visible = false;
                textBox_check_res.Visible = false;
                menu_save.Visible = false;
                result_actual_single.Visible = false;
                button_next.Visible = false;
                button_prev.Visible = false;
                actual_number.Visible = false;
            }
            else
            {
                toolStrip1.Visible = false;
                res_toolStrip.Visible = false;
                log_res_tool.Visible = false;
                mainlabel.Visible = true;
                queryBox.Visible = true;
                panel_find.Visible = true;
                panel_sort.Visible = true;
                button_find_res.Visible = true;
                button_sort_res.Visible = true;
                metainfo.Visible = true;
                textBox_check_res.Visible = true;
                menu_save.Visible = true;
                result_actual_single.Visible = true;
                button_next.Visible = true;
                button_prev.Visible = true;
                actual_number.Visible = true;
            }
        }
        private void PrintTheProduct(Product p)
        {
            result_actual_single.Text = "";
            result_actual_single.Text += p.name + " ";
            result_actual_single.Text += p.id + "\r\n";
            result_actual_single.Text += p.customer + "\r\n";
            result_actual_single.Text += p.email + "\r\n";
            result_actual_single.Text += p.date.ToString();
            res_toolStrip.Text = result_actual_single.Text;
        }
        private void FindClick()
        {
            ArrayList products = Find_Sort.IWhantToFind(listP, queryBox.Text, radioButton_f_model.Checked,
                                   radioButton_f_name.Checked, radioButton_f_mail.Checked,
                                   (queryBox.Text[0] == '$'));
            int counted = 0;
            listP = new List(products.Count);
            foreach (Product p in products)
            {
                listP.products[counted] = p;
                ++counted;
            }
            listP = Find_Sort.IWhantToSort(listP, radioButton_s_date.Checked,
                radioButton_s_size.Checked, radioButton_s_name.Checked, true);
            counter = 0;
            if (listP.GetCount() > 0)
            {
                PrintTheProduct(listP.products[counter]);
                actual_number.Text = toolStripActual.Text = (counter + 1).ToString();
            }
            else
                res_toolStrip.Text = result_actual_single.Text = "No matches";
        }
        private void FindClickNoRadio(int onetwothree)
        {
            ArrayList products;
            if (onetwothree == 1)
                products = Find_Sort.IWhantToFind(listP, toolStripFind.Text, true,
                                    false, false,
                                    (toolStripFind.Text[0] == '$'));
            else if(onetwothree == 2)
                products = Find_Sort.IWhantToFind(listP, toolStripFind.Text, false,
                                    true, false,
                                    (toolStripFind.Text[0] == '$'));
            else
                products = Find_Sort.IWhantToFind(listP, toolStripFind.Text, false,
                                    false, true,
                                    (toolStripFind.Text[0] == '$'));
                int counter = 0;
            listP = new List(products.Count);
            foreach (Product p in products)
            {
                listP.products[counter] = p;
                ++counter;
            }
            listP = Find_Sort.IWhantToSort(listP, true,
                false, false, true);
            counter = 0;
            if (listP.GetCount() > 0)
            {
                PrintTheProduct(listP.products[counter]);
                actual_number.Text = toolStripActual.Text = (counter + 1).ToString();
            }
            else
                res_toolStrip.Text = result_actual_single.Text = "Нет совпадений";
        }
        private void SortClick()
        {
            listP = Find_Sort.IWhantToSort(listP, radioButton_s_date.Checked, radioButton_s_size.Checked, radioButton_s_name.Checked, false);
            counter = 0;
            PrintTheProduct(listP.products[counter]);
        }
        private void SortClickNoRadio(int onetwothree)
        {
            if (onetwothree == 1)
                listP = Find_Sort.IWhantToSort(listP, false, true, false, false);
            else if (onetwothree == 2)
                listP = Find_Sort.IWhantToSort(listP, false, false, true, false);
            else
                listP = Find_Sort.IWhantToSort(listP, true, false, false, false);
            counter = 0;
            PrintTheProduct(listP.products[counter]);
        }
        private void Time(List list, string action)
        {
            metainfo.Text = "";
            metainfo.Text += list.GetCount().ToString() + " ,";
            metainfo.Text += DateTime.Now.ToString() + " ,";
            metainfo.Text += action;
            log_res_tool.Text = textBox_check_res.Text = metainfo.Text;
        }
        private void SaveTheResult(List list)
        {
            XmlSerializer XMLmatter = new XmlSerializer(typeof(List));
            using (FileStream fx = new FileStream("D:\\ExtendedData\\Laboratory\\ООТПиСП\\l3\\OOP_Lab_3\\findsort.xml", FileMode.Create))
            {
                XMLmatter.Serialize(fx, list);
            }
        }
    }
    static class Find_Sort
    {
        static public ArrayList IWhantToFind(List list, string query, bool model, bool name, bool mail, bool reg)
        {
            list = new List(8);
            list.FillTheList();
            ArrayList result = new ArrayList();
            if (!reg)
            {
                if (model)
                {
                    IEnumerable<Product> result_model = list.products
                                                        .Where(n => (n.name == query) || (n.id == query))
                                                        .Select(n => n);
                    foreach (Product p in result_model)
                    {
                        result.Add(p);
                    }
                }
                else if (name)
                {
                    IEnumerable<Product> result_name = list.products
                                                       .Where(n => n.customer == query)
                                                       .Select(n => n);
                    foreach (Product p in result_name)
                    {
                        result.Add(p);
                    }
                }
                else if (mail)
                {
                    IEnumerable<Product> result_email = list.products
                                                       .Where(n => n.email == query)
                                                       .Select(n => n);
                    foreach (Product p in result_email)
                    {
                        result.Add(p);
                    }
                }
            }
            else
            {
                query = query.Replace("$", string.Empty);
                
                Regex regex = new Regex(query);

                if (model)
                {
                    for (int i = 0; i < list.GetSize(); ++i)
                    if
                    ((regex.IsMatch(list.products[i].name))||(regex.IsMatch(list.products[i].id)))
                    {
                        result.Add(list.products[i]);
                    }
                }
                else if (name)
                {
                    for (int i = 0; i < list.GetSize(); ++i)
                        if (regex.IsMatch(list.products[i].customer))
                            result.Add(list.products[i]);
                }
                else if (mail)
                {
                    for (int i = 0; i < list.GetSize(); ++i)
                        if (regex.IsMatch(list.products[i].email))
                            result.Add(list.products[i]);
                }
                /*Regex.IsMatch(emailbox.Text, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", RegexOptions.IgnoreCase)*/
            }
            return result;
        }

        static public List IWhantToSort(List list, bool date, bool size, bool name, bool created)
        {
            if (!created)
                list.FillTheList();
            List result = new List(list.GetCount());
            if (date)
            {
                IEnumerable<Product> result_date = list.products
                                              .OrderBy(n => n.date)
                                              .ThenBy(n => n.size)
                                              .ThenBy(n => n.name)
                                              .Select(n => n);
                foreach (Product p in result_date)
                    result.Add(p);
            }
            else if (size)
            {
                IEnumerable<Product> result_size = list.products
                                              .OrderBy(n => n.size)
                                              .ThenBy(n => n.date)
                                              .ThenBy(n => n.name)
                                              .Select(n => n);
                foreach (Product p in result_size)
                    result.Add(p);
            }
            else if (name)
            {
                IEnumerable<Product> result_name = list.products
                                              .OrderBy(n => n.name)
                                              .ThenBy(n => n.date)
                                              .ThenBy(n => n.size)
                                              .Select(n => n);
                foreach (Product p in result_name)
                    result.Add(p);
            }
            return result;
        }
    }
}
