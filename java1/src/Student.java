import java.math.BigDecimal;
import java.math.RoundingMode;
import java.util.ArrayList;
import java.util.List;

public class Student implements Calc {
    public Student(String firstName, String lastName, double OOP,double OAiP,double PS,double SA ) throws Exception {
        this.firstName = firstName;
        this.lastName = lastName;
        if(OOP>0&&OOP<=10&&OAiP>0&&OAiP<=10&&PS>0&&PS<=10&&SA>0&&SA<=10) {
            this.OOP = OOP;
            this.OAiP = OAiP;
            this.PS = PS;
            this.SA = SA;
        } else throw new Exception("Ошибка передачи оценок");
    }
    private String firstName;
    private String lastName;

    private double OOP=0;
    private double OAiP=0;
    private double PS=0;
    private double SA=0;

    public double sr(){
        return new BigDecimal((OOP+OAiP+PS+SA)/4).setScale(2, RoundingMode.HALF_UP).doubleValue();
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    public String getLastName() {
        return lastName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public String getFirstName() {
        return firstName;
    }
}
