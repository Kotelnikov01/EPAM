import java.math.BigDecimal;
import java.math.RoundingMode;
import java.util.ArrayList;
import java.util.List;

public class Faculty implements Calc {
    public Faculty(String fName){
        this.fName = fName;
    }
    private String fName;
    private ArrayList<Group> gr=new ArrayList<Group>();

    public void add(Group g){
        gr.add(g);
    }
    public double sr() throws Exception {
        if(gr.size()!=0) {
            double ball = 0;
            for (Group i : gr) {
                ball += i.sr();
            }
            return new BigDecimal(ball / gr.size()).setScale(2, RoundingMode.HALF_UP).doubleValue();
        } else throw new Exception("В факультете нет групп!");
    }

    public void setfName(String fName) {
        this.fName = fName;
    }

    public String getfName() {
        return fName;
    }
}
