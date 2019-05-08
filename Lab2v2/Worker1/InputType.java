import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;

public class InputType implements Serializable {
    private static final long serialVersionUID = 101L;
    private ArrayList<Integer> list;

    public ArrayList<Integer> getList() {
        return list;
    }
    public void setList(ArrayList<Integer> list) {
        this.list = list;
    }
}
