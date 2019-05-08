import java.util.ArrayList;
import java.util.List;

public class Farmer {
    public static void main(String[] args) {
        CalcObject zObiekt1;
        CalcObject zObiekt2;
        CalcObject2 zObiekt3;
        ResultType wynik1;
        ResultType wynik2;
        ResultType wynik3;
        InputType inObj1;
        InputType inObj2;
        InputType2 inObj3;
        if (args.length == 0) {
            System.out.println("You have to enter RMI object address in	the form: // host_address/service_name ");
            return;
        }
        String adres1 = args[0];
        String adres2 = args[1];
        String adres3 = args[2];

        ArrayList<Integer> lista = inicjalizujListe();

        List<Integer> part1 = new ArrayList<Integer>(lista.subList(0, lista.size() /2));
        List<Integer> part2 = new ArrayList<Integer>(lista.subList(lista.size() /2, lista.size()));
        System.out.println("Lista1: ");
        System.out.println(part1);
        System.out.println("Lista2: ");
        System.out.println(part2);

        inObj1 = new InputType();
        inObj1.setList(part1);
        inObj2 = new InputType();
        inObj2.setList(part2);

        // //use this if needed
        // if (System.getSecurityManager() == null)
        // System.setSecurityManager(new SecurityManager());


        try {
            zObiekt1 = (CalcObject) java.rmi.Naming.lookup(adres1);
        } catch (Exception e) {
            System.out.println("Nie mozna pobrac referencji do "+adres1);
            e.printStackTrace();
            return;
        }
        try {
            zObiekt2 = (CalcObject) java.rmi.Naming.lookup(adres2);
        } catch (Exception e) {
            System.out.println("Nie mozna pobrac referencji do "+adres2);
            e.printStackTrace();
            return;
        }

        System.out.println("Referencja do "+adres1+" jest pobrana.");
        System.out.println("Referencja do "+adres2+" jest pobrana.");

        try {
            wynik1 = zObiekt1.calculate(inObj1);
            wynik2 = zObiekt2.calculate(inObj2);
        } catch (Exception e) {
            System.out.println("Blad zdalnego wywolania.");
            e.printStackTrace();
            return;
        }

        if(wynik1.getResult()||wynik1.getResult()) {
            List<Integer> result = new ArrayList<>();
            inObj3 = new InputType2();
            inObj3.setList(wynik1.getList());
            inObj3.setList2(wynik2.getList());
            inObj3.setTime(3000);

            try {
                zObiekt3 = (CalcObject2) java.rmi.Naming.lookup(adres3);
            } catch (Exception e) {
                System.out.println("Nie mozna pobrac referencji do "+adres3);
                e.printStackTrace();
                return;
            }
            System.out.println("Referencja do "+adres3+" jest pobrana.");

            try {
                wynik3 = zObiekt3.calculate(inObj3);
            } catch (Exception e) {
                System.out.println("Blad zdalnego wywolania.");
                e.printStackTrace();
                return;
            }
            System.out.println("Znaleziono Integerów:");
            System.out.println(wynik3.getList());
        }
        else
            System.out.println("Nie znaleziono Integerów!");

        return;
    }


    public static ArrayList<Integer> inicjalizujListe() {
        ArrayList<Integer> lista = new ArrayList<>();

        for (int i = 0; i < 13; i++) {
            int liczba = (int) Math.random() * 100;
            lista.add(liczba);
        }
        return lista;
    }
}