import java.math.BigDecimal;
import java.math.RoundingMode;
import java.util.ArrayList;

public class University implements Calc {
    public University(String uName ){
        this.uName = uName;
    }
    private String uName;
    private ArrayList<Faculty> ft = new ArrayList<Faculty>();
    public void add(Faculty f){
        ft.add(f);
    }
    public double sr() throws Exception {
        if(ft.size()!=0) {
            double ball = 0;
            for (Faculty i : ft) {
                ball += i.sr();
            }
            return new BigDecimal(ball / ft.size()).setScale(2, RoundingMode.HALF_UP).doubleValue();
        } else throw new Exception("В университете нет факультетов!");
    }

    public void setuName(String uName) {
        this.uName = uName;
    }

    public String getuName() {
        return uName;
    }
}
