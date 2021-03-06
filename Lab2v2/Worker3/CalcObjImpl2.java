import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.util.ArrayList;
import java.util.Collections;

public class CalcObjImpl2 extends UnicastRemoteObject implements CalcObj2 {
    private static final long serialVersionUID = 101L;

    public CalcObjImpl2() throws RemoteException{
        super();
    }

    @Override
    public ResultType calculate(InputType2 inputParam) throws RemoteException {
        ArrayList<Integer> list1 = inputParam.getList();
        ArrayList<Integer> list2 = inputParam.getList2();
        ArrayList<Integer> listaWynikowa = new ArrayList<>();
        int time = inputParam.getTime();


        listaWynikowa.addAll(list1);
        listaWynikowa.addAll(list2);
        Collections.sort(listaWynikowa);

        try {
            Thread.sleep(time);
        } catch (InterruptedException e) {
            e.printStackTrace();
        }

        ResultType wynik = new ResultType();
        wynik.setList(listaWynikowa);
        wynik.setResult(false);

        return wynik;
    }
}
