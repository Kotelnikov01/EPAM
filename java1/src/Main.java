public class Main {

    public static void main(String ... args) throws Exception {
        Student s1 = new Student("Даня","Ключников",5,5,7,9);
        Student s2 = new Student("Юрий","Черняк",5,8,3,6);
        Student s3 = new Student("Станислав","Морозов",8,9,6,10);
        Student s4 = new Student("Ксения","Ляхова",3,8,9,5);
        Student s5 = new Student("Мирон","Федоров",4,7,8,3);
        Student s6 = new Student("Владислав","Янковский",9,9,9,9);
        Student s7 = new Student("Стас","Жамойть",9,9,9,9);
        Student s8 = new Student("Олег","Михайлов",9,9,9,9);



        Group g1 = new Group(1);
        g1.add(s1);
        g1.add(s2);
        Group g2 = new Group(2);
        g2.add(s3);
        g2.add(s4);
        Group g3 = new Group(3);
        g3.add(s5);
        g3.add(s6);
        Group g4 = new Group(4);
        g4.add(s7);
        g4.add(s8);

        Faculty f1 = new Faculty("FIT");
        f1.add(g1);
        f1.add(g2);
        Faculty f2 = new Faculty("IEF");
        f2.add(g3);
        f2.add(g4);

        University u = new University("BSTU");
        u.add(f1);
        u.add(f2);

        System.out.println("Средний бал первого студента:");
        System.out.println(s1.sr());
        System.out.println("Средний бал первой группы:");
        System.out.println(g1.sr());
        System.out.println("Средний бал первого факультета:");
        System.out.println(f1.sr());
        System.out.println("Средний бал университета:");
        System.out.println(u.sr());
    }
}
