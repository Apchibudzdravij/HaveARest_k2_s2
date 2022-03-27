package basejava;

import java.util.Objects;
/*interface IDeletable
{
    void delete(char delchar);
}*/

/**
 @author Mememememe
 @version 1.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0
 */
public class WrapperString
{
    private String wrap;

    public void replace(char oldchar, char newchar) {
        this.wrap = this.wrap.replace(oldchar, newchar);
    }

    public WrapperString(String wrap) {
        this.wrap = wrap;
    }
    public WrapperString() {
        this.wrap = "";
    }
    public String getWrap() {
        return wrap;
    }

    public void setWrap(String wrap) {
        this.wrap = wrap;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        WrapperString that = (WrapperString) o;
        return Objects.equals(wrap, that.wrap);
    }

    @Override
    public int hashCode() {
        return Objects.hash(wrap);
    }

    @Override
    public String toString() {
        return "WrapperString{" +
                "wrap='" + wrap + '\'' +
                '}';
    }
}