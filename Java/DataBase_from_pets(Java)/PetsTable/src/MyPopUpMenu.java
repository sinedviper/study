import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JMenuItem;
import javax.swing.JPopupMenu;

public class MyPopUpMenu extends JPopupMenu {
	
	private JMenuItem delItem = new JMenuItem("Удалить");
	private JMenuItem editItem = new JMenuItem("Редактировать");
	private int id;
	
	public MyPopUpMenu(int id) {
		this.add(delItem);
		this.add(editItem);
		delItem.addActionListener(new DelAction());
		this.id = id;
	}
	
	class DelAction implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			DBConnector.deleteRow("PETS","ID" ,id);
		}
		
	}

}
