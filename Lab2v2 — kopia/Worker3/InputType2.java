import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;

public class InputType2 implements Serializable {
    private static final long serialVersionUID = 101L;
    private ArrayList <Integer> list;
    private ArrayList <Integer> list2;
    private int time;

    public ArrayList<Integer> getList() {
        return list;
    }
    public void setList(ArrayList<Integer> list) {
        this.list = list;
    }
    public ArrayList<Integer> getList2() {
        return list2;
    }
    public void setList2(ArrayList<Integer> list2) {
        this.list2 = list2;
    }
    public int getTime() {
        return time;
    }
    public void setTime(int time) {
        this.time = time;
    }


}