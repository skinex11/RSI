import java.io.Serializable;
import java.util.ArrayList;

public class ResultType implements Serializable {
    private static final long serialVersionUID = 102L;
    private ArrayList <Integer> list;
    private boolean result;

    public ArrayList<Integer> getList() {
        return list;
    }
    public void setList(ArrayList<Integer> list) {
        this.list = list;
    }
    public boolean getResult() {
        return result;
    }
    public void setResult(boolean result) {
        this.result = result;
    }
}