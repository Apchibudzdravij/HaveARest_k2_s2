package Main.Tax;

import Automobile.Tax.FreightCar;
import Automobile.Tax.LightweightAuto;
import Owner.TaxDeportOwner;
import Serial.DeportHandler;
import Serial.Serializator;
import TaxiDeport.Deport;
import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import org.xml.sax.SAXException;
import org.xml.sax.XMLReader;
import org.xml.sax.helpers.XMLReaderFactory;

import javax.xml.XMLConstants;
import javax.xml.transform.Source;
import javax.xml.transform.stream.StreamSource;
import javax.xml.validation.Schema;
import javax.xml.validation.SchemaFactory;
import javax.xml.validation.Validator;
import java.io.File;
import java.io.IOException;
import java.io.InvalidObjectException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collection;
import java.util.stream.Stream;

public class Main {
    public static void main(String[] args) throws IOException {
        boolean eightWheels = false;
        boolean sixWheels = true;
        Deport deport = new Deport();
        deport.AddAuto(new LightweightAuto(90, 14000,
                                           "12345qwe67", "1234AA7",
                                           10.0f));
        deport.AddAuto(new LightweightAuto(270, 270000,
                                            "67890rty12", "0001AA1",
                                            60.0f));
        deport.AddAuto(new FreightCar(20, 50500, "8765hea16",
                                      "0978HE9", 88.88f, eightWheels));
        deport.AddAuto(new FreightCar(40, 36000, "35676fgh87",
                                      "4862SA6", 38.5f, sixWheels));

        TaxDeportOwner owner = new TaxDeportOwner();

        System.out.println(deport.toString());

        String filename = "src/Data/xml1.xml";
        String schemaname = "src/Data/xml1.xsd";
        Schema schems = null;
        String language = XMLConstants.W3C_XML_SCHEMA_NS_URI;
        SchemaFactory factory = SchemaFactory.newInstance(language);
        try{
            //-----------------1-2-3-----------------
            schems = factory.newSchema(new File(schemaname));
            Validator validator = schems.newValidator();
            Source source = new StreamSource(filename);
            validator.validate(source);
            System.out.println(".XML file was successfully validated!");
            //-------------------4-------------------
            XMLReader reader = XMLReaderFactory.createXMLReader();
            DeportHandler handler = new DeportHandler();
            reader.setContentHandler(handler);
            reader.parse("src/Data/xml1.xml");
            //-------------------5-------------------
            Gson gson = new Gson();
            String jsony = new GsonBuilder().excludeFieldsWithoutExposeAnnotation()
                                            .create().toJson(deport.getLA(1));
            System.out.println("json: " + jsony);
            //-------------------6-------------------
            Collection<LightweightAuto> collection =
                    Arrays.asList(deport.getLA(0), deport.getLA(1), deport.getLA(0));
            System.out.println("\nTotal number of LA with speed "
                    + deport.getLA(0).getMaxSpeed() + ": "
                    + collection.stream().filter(deport.getLA(0)::equals).count());
            System.out.println("\nTotal cost of 3 LA: " + collection.stream().mapToInt((s) -> s.getCost()).sum());
            System.out.println("\nIs stream parallel? " + (collection.stream().isParallel() ? "Yes :)" : "No :/"));
        }
        catch (SAXException e){
            System.err.println(filename + " SAX error " + e.getMessage());
        }
        catch (IOException e){
            System.err.println(" io error " + e.getMessage());
        }
    }
}
