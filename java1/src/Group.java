import java.math.BigDecimal;
import java.math.RoundingMode;
import java.util.ArrayList;
import java.util.List;

public class Group implements Calc {
    public Group(int GroupNumber ){
        this.GroupNumber = GroupNumber;
    }
    private int GroupNumber;
    private ArrayList<Student> st = new ArrayList<Student>();
    public void add(Student s){
        st.add(s);
    }

    public double sr() throws Exception {
        if(st.size()!=0) {
            double ball = 0;
            for (Student i : st) {
                ball += i.sr();
            }
            return new BigDecimal(ball / st.size()).setScale(2, RoundingMode.HALF_UP).doubleValue();
        } else throw new Exception("В группе нет студентов!");
    }


    public void setGroupNumber(int groupNumber) {
        GroupNumber = groupNumber;
    }

    public int getGroupNumber() {
        return GroupNumber;
    }
}
