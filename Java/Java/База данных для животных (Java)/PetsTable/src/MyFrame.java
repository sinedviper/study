import java.awt.Dimension;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.awt.*;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTabbedPane;
import javax.swing.JTable;
import javax.swing.JTextField;
import javax.swing.SwingUtilities;
import javax.swing.*;

public class MyFrame extends JFrame{
	// Поле с вкладками
	JTabbedPane tabbedPane = new JTabbedPane();
	JPanel panelPets = new JPanel();
	JPanel panelDoctors = new JPanel();
	JPanel panelCategory = new JPanel();
	JPanel panelRecord = new JPanel();
	PreparedStatement state = null;
	Connection conn = null;
	//---------------------------------------------  "Pets"
	JTable tablePets = new JTable();
	JScrollPane scroller = new JScrollPane(tablePets);
	int idPets = -1;
	JPanel upPanel = new JPanel();
	JPanel midPanel = new JPanel();
	JPanel downPanel = new JPanel();
	JLabel lnameLabelPets = new JLabel("Name:");
	JLabel ageLabelPets = new JLabel("Age:");
	JLabel genderLabelPets = new JLabel("Gender:");
	JTextField lnameTFieldPets = new JTextField();
	JTextField ageTFieldPets = new JTextField();
	String[] genderListPets = {"Man","Woman"};
	JComboBox<String> genderComboPets = new JComboBox<>(genderListPets);
	JComboBox<String> nameComboPets = new JComboBox<String>();
	String[] SearchPetsList = {"Name","Age"};
	JComboBox<String> SearchComboPets = new JComboBox<>(SearchPetsList);
	JButton addBtnPets = new JButton("Add in table");
	JButton delBtnPets = new JButton("Delete in table");
	JButton editBtnPets = new JButton("Edit in table");
	JButton searchBtnPets = new JButton("Search in table");

	//---------------------------------------------  "Dostors"
	JTable tableDoctors = new JTable();
	JScrollPane scrollerDoctors = new JScrollPane(tableDoctors);
	int idDoctors = -1;
	JPanel upPanelDoctors = new JPanel();
	JPanel midPanelDoctors = new JPanel();
	JPanel downPanelDoctors = new JPanel();
	JLabel fnameLabelDoctors = new JLabel("Surname:");
	JLabel lnameLabelDoctors = new JLabel("Name:");
	JLabel ageLabelDoctors = new JLabel("Age:");
	JLabel genderLabelDoctors = new JLabel("Gender:");
	JTextField fnameTFieldDoctors = new JTextField();
	JTextField lnameTFieldDoctors= new JTextField();
	JTextField ageTFieldDoctors= new JTextField();
	String[] genderListDoctors = {"Man","Woman"};
	JComboBox<String> genderComboDoctors = new JComboBox<>(genderListDoctors);
	JComboBox<String> nameComboDoctors = new JComboBox<String>();
	String[] SearchDoctorsList = {"Fname","Lname","Age"};
	JComboBox<String> SearchComboDoctors = new JComboBox<>(SearchDoctorsList);
	JButton addBtnDoctors = new JButton("Add in table");
	JButton delBtnDoctors = new JButton("Delete in table");
	JButton editBtnDoctors = new JButton("Edit in table");
	JButton searchBtnDoctors = new JButton("Search in table");

	//---------------------------------------------  "Category"
	JTable tableCategory = new JTable();
	JScrollPane scrollerCategory = new JScrollPane(tableCategory);
	int idCategory = -1;
	JComboBox<String> nameComboCategory = new JComboBox<String>();
	JComboBox<String> nameComboCategory2 = new JComboBox<String>();
	JPanel upPanelCategory = new JPanel();
	JPanel midPanelCategory = new JPanel();
	JPanel downPanelCategory = new JPanel();
	JLabel nameLabelCategory = new JLabel("Name:");
	JTextField nameTFieldCategory = new JTextField();
	JButton addBtnCategory = new JButton("Add in table");
	JButton delBtnCategory = new JButton("Delete in table");
	JButton editBtnCategory = new JButton("Edit in table");

	//---------------------------------------------  "Records"
	//----Leftside
	JTable tableRecordsLeft = new JTable();
	JScrollPane scrollerRecordsLeft = new JScrollPane(tableRecordsLeft);
	JPanel upPanelRecordsLeft = new JPanel();
	JPanel downPanelRecordsLeft = new JPanel();
	JLabel animalLabelRecordsLeft = new JLabel("Add in category animal");
	JButton addBtnRecordsLeft = new JButton("Add");
	JButton delBtnRecordsLeft = new JButton("Delete");
	JButton searchBtnPetsLeft = new JButton("Search pets");
	JButton searchBtnRecordsLeft = new JButton("Search category");
	JButton defaultBtnRecordsLeft = new JButton("Default");
	//----Rightside
	JTable tableRecordsRights = new JTable();
	JScrollPane scrollerRecordsRight = new JScrollPane(tableRecordsRights);
	JPanel upPanelRecordsRight = new JPanel();
	JPanel downPanelRecordsRight = new JPanel();
	JLabel doctorsLabelRecordsRight = new JLabel("Add in category doctors");
	JButton addBtnRecordsRight = new JButton("Add");
	JButton delBtnRecordsRight = new JButton("Delete");
	JButton searchBtnDoctorsRight = new JButton("Search doctors");
	JButton searchBtnRecordsRight = new JButton("Search category");
	JButton defaultBtnRecordsRight = new JButton("Default");

	public MyFrame() {
		// Отображения приложения
		this.setVisible(true);
		this.setSize(800, 800);
		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		// Добавляем вкладки
		this.add(tabbedPane);
		tabbedPane.add(panelPets, "Pets");
		tabbedPane.add(panelDoctors, "Doctors");
		tabbedPane.add(panelCategory, "Category");
		tabbedPane.add(panelRecord, "Record");
		//------------------------------------------------------------------------- Pets
		tablePets.setSelectionBackground(new Color(0,0,0));
		tablePets.setSelectionForeground(new Color(255,255,255));
		//Label панели
		lnameLabelPets.setForeground(new Color(0,0,0));
		lnameLabelPets.setHorizontalAlignment(SwingConstants.CENTER);
		ageLabelPets.setForeground(new Color(0,0,0));
		ageLabelPets.setHorizontalAlignment(SwingConstants.CENTER);
		genderLabelPets.setForeground(new Color(0,0,0));
		genderLabelPets.setHorizontalAlignment(SwingConstants.CENTER);
		//TFiled панели
		lnameTFieldPets.setBackground(new Color(0,0,0));
		lnameTFieldPets.setForeground(new Color(255,255,255));
		lnameTFieldPets.setHorizontalAlignment(SwingConstants.CENTER);
		lnameTFieldPets.setBorder(BorderFactory.createMatteBorder(1, 1, 0, 1, Color.white));
		ageTFieldPets.setBackground(new Color(0,0,0));
		ageTFieldPets.setForeground(new Color(255,255,255));
		ageTFieldPets.setHorizontalAlignment(SwingConstants.CENTER);
		ageTFieldPets.setBorder(BorderFactory.createMatteBorder(1, 1, 1, 1, Color.white));
		//ComboBox панели
		genderComboPets.setBackground(new Color(0,0,0));
		genderComboPets.setForeground(new Color(255,255,255));
		genderComboPets.setBorder(BorderFactory.createMatteBorder(0, 0, 0, 0, Color.black));
		SearchComboPets.setBackground(new Color(0,0,0));
		SearchComboPets.setForeground(new Color(255,255,255));
		SearchComboPets.setBorder(BorderFactory.createMatteBorder(0, 0, 0, 0, Color.black));
		//Кнопки
		addBtnPets.setBackground(new Color(0,0,0));
		addBtnPets.setForeground(new Color(255,255,255));
		addBtnPets.setBorder(BorderFactory.createMatteBorder(4, 4, 4, 4, Color.black));
		delBtnPets.setBackground(new Color(0,0,0));
		delBtnPets.setForeground(new Color(255,255,255));
		delBtnPets.setBorder(BorderFactory.createMatteBorder(4, 4, 4, 4, Color.black));
		editBtnPets.setBackground(new Color(0,0,0));
		editBtnPets.setForeground(new Color(255,255,255));
		editBtnPets.setBorder(BorderFactory.createMatteBorder(4, 4, 4, 4, Color.black));
		searchBtnPets.setBackground(new Color(0,0,0));
		searchBtnPets.setForeground(new Color(255,255,255));
		searchBtnPets.setBorder(BorderFactory.createMatteBorder(4, 4, 4, 4, Color.black));
		//--------------------------------------------
		panelPets.setLayout(new GridLayout(3, 1));
		panelPets.add(upPanel);
		panelPets.add(midPanel);
		panelPets.add(downPanel);
		//upPanel
		upPanel.setLayout(new GridLayout(4, 2));
		upPanel.add(lnameLabelPets);
		upPanel.add(lnameTFieldPets);
		upPanel.add(ageLabelPets);
		upPanel.add(ageTFieldPets);
		upPanel.add(genderLabelPets);
		upPanel.add(genderComboPets);
		//midPanel
		midPanel.add(addBtnPets);
		addBtnPets.addActionListener(new AddActionPets());
		midPanel.add(delBtnPets);
		delBtnPets.addActionListener(new DelActionPets());
		midPanel.add(editBtnPets);
		editBtnPets.addActionListener(new EditActionPets());
		midPanel.add(SearchComboPets);
		midPanel.add(searchBtnPets);
		searchBtnPets.addActionListener(new SearchActionPets());
		//downPanel
		tablePets.setModel(DBConnector.selectAll("PETS"));
		scroller.setPreferredSize(new Dimension(700, 200));
		downPanel.add(scroller);
		tablePets.addMouseListener(new TableMouseClick());
		//------------------------------------------------------------------------- Doctors
		tableDoctors.setSelectionBackground(new Color(0,0,0));
		tableDoctors.setSelectionForeground(new Color(255,255,255));
		//Label панели
		fnameLabelDoctors.setForeground(new Color(0,0,0));
		fnameLabelDoctors.setHorizontalAlignment(SwingConstants.CENTER);
		lnameLabelDoctors.setForeground(new Color(0,0,0));
		lnameLabelDoctors.setHorizontalAlignment(SwingConstants.CENTER);
		ageLabelDoctors.setForeground(new Color(0,0,0));
		ageLabelDoctors.setHorizontalAlignment(SwingConstants.CENTER);
		genderLabelDoctors.setForeground(new Color(0,0,0));
		genderLabelDoctors.setHorizontalAlignment(SwingConstants.CENTER);
		//TFiled панели
		fnameTFieldDoctors.setBackground(new Color(0,0,0));
		fnameTFieldDoctors.setForeground(new Color(255,255,255));
		fnameTFieldDoctors.setHorizontalAlignment(SwingConstants.CENTER);
		fnameTFieldDoctors.setBorder(BorderFactory.createMatteBorder(1, 1, 0, 1, Color.white));
		lnameTFieldDoctors.setBackground(new Color(0,0,0));
		lnameTFieldDoctors.setForeground(new Color(255,255,255));
		lnameTFieldDoctors.setHorizontalAlignment(SwingConstants.CENTER);
		lnameTFieldDoctors.setBorder(BorderFactory.createMatteBorder(1, 1, 0, 1, Color.white));
		ageTFieldDoctors.setBackground(new Color(0,0,0));
		ageTFieldDoctors.setForeground(new Color(255,255,255));
		ageTFieldDoctors.setHorizontalAlignment(SwingConstants.CENTER);
		ageTFieldDoctors.setBorder(BorderFactory.createMatteBorder(1, 1, 1, 1, Color.white));
		//ComboBox панели
		genderComboDoctors.setBackground(new Color(0,0,0));
		genderComboDoctors.setForeground(new Color(255,255,255));
		genderComboDoctors.setBorder(BorderFactory.createMatteBorder(0, 0, 0, 0, Color.black));
		SearchComboDoctors.setBackground(new Color(0,0,0));
		SearchComboDoctors.setForeground(new Color(255,255,255));
		SearchComboDoctors.setBorder(BorderFactory.createMatteBorder(0, 0, 0, 0, Color.black));
		//Кнопки
		addBtnDoctors.setBackground(new Color(0,0,0));
		addBtnDoctors.setForeground(new Color(255,255,255));
		addBtnDoctors.setBorder(BorderFactory.createMatteBorder(4, 4, 4, 4, Color.black));
		delBtnDoctors.setBackground(new Color(0,0,0));
		delBtnDoctors.setForeground(new Color(255,255,255));
		delBtnDoctors.setBorder(BorderFactory.createMatteBorder(4, 4, 4, 4, Color.black));
		editBtnDoctors.setBackground(new Color(0,0,0));
		editBtnDoctors.setForeground(new Color(255,255,255));
		editBtnDoctors.setBorder(BorderFactory.createMatteBorder(4, 4, 4, 4, Color.black));
		searchBtnDoctors.setBackground(new Color(0,0,0));
		searchBtnDoctors.setForeground(new Color(255,255,255));
		searchBtnDoctors.setBorder(BorderFactory.createMatteBorder(4, 4, 4, 4, Color.black));
		//--------------------------------------------
		panelDoctors.setLayout(new GridLayout(3, 1));
		panelDoctors.add(upPanelDoctors);
		panelDoctors.add(midPanelDoctors);
		panelDoctors.add(downPanelDoctors);
		upPanelDoctors.setLayout(new GridLayout(4, 2));
		upPanelDoctors.add(fnameLabelDoctors);
		upPanelDoctors.add(fnameTFieldDoctors);
		upPanelDoctors.add(lnameLabelDoctors);
		upPanelDoctors.add(lnameTFieldDoctors);
		upPanelDoctors.add(ageLabelDoctors);
		upPanelDoctors.add(ageTFieldDoctors);
		upPanelDoctors.add(genderLabelDoctors);
		upPanelDoctors.add(genderComboDoctors);
		midPanelDoctors.add(addBtnDoctors);
		addBtnDoctors.addActionListener(new AddActionDoctors());
		midPanelDoctors.add(delBtnDoctors);
		delBtnDoctors.addActionListener(new DelActionDoctors());
		midPanelDoctors.add(editBtnDoctors);
		editBtnDoctors.addActionListener(new EditActionDoctors());
		midPanelDoctors.add(SearchComboDoctors);
		midPanelDoctors.add(searchBtnDoctors);
		searchBtnDoctors.addActionListener(new SearchActionDoctors());
		tableDoctors.setModel(DBConnector.selectAll("DOCTORS"));
		scrollerDoctors.setPreferredSize(new Dimension(700, 200));
		downPanelDoctors.add(scrollerDoctors);
		tableDoctors.addMouseListener(new TableMouseClickDoctors());

		//------------------------------------------------------------------------- Category
		tableCategory.setSelectionBackground(new Color(0,0,0));
		tableCategory.setSelectionForeground(new Color(255,255,255));
		//Label панели
		nameLabelCategory.setForeground(new Color(0,0,0));
		nameLabelCategory.setHorizontalAlignment(SwingConstants.CENTER);
		//TFiled панели
		nameTFieldCategory.setBackground(new Color(0,0,0));
		nameTFieldCategory.setForeground(new Color(255,255,255));
		nameTFieldCategory.setHorizontalAlignment(SwingConstants.CENTER);
		nameTFieldCategory.setBorder(BorderFactory.createMatteBorder(1, 1, 1, 1, Color.white));
		//Кнопки
		addBtnCategory.setBackground(new Color(0,0,0));
		addBtnCategory.setForeground(new Color(255,255,255));
		addBtnCategory.setBorder(BorderFactory.createMatteBorder(4, 4, 4, 4, Color.black));
		delBtnCategory.setBackground(new Color(0,0,0));
		delBtnCategory.setForeground(new Color(255,255,255));
		delBtnCategory.setBorder(BorderFactory.createMatteBorder(4, 4, 4, 4, Color.black));
		editBtnCategory.setBackground(new Color(0,0,0));
		editBtnCategory.setForeground(new Color(255,255,255));
		editBtnCategory.setBorder(BorderFactory.createMatteBorder(4, 4, 4, 4, Color.black));
		//--------------------------------------------
		JPanel upPanelCategory1 = new JPanel();
		JPanel upPanelCategory2 = new JPanel();
		panelCategory.setLayout(new GridLayout(3, 2));
		panelCategory.add(upPanelCategory);
		panelCategory.add(midPanelCategory);
		panelCategory.add(downPanelCategory);
		upPanelCategory.setLayout(new GridLayout(4,2));
		upPanelCategory.add(upPanelCategory2);
		upPanelCategory.add(upPanelCategory1);
		upPanelCategory1.setLayout(new GridLayout(1,1));
		upPanelCategory1.add(nameLabelCategory);
		upPanelCategory1.add(nameTFieldCategory);
		midPanelCategory.add(addBtnCategory);
		addBtnCategory.addActionListener(new AddActionCategory());
		midPanelCategory.add(delBtnCategory);
		delBtnCategory.addActionListener(new DelActionCategory());
		midPanelCategory.add(editBtnCategory);
		editBtnCategory.addActionListener(new EditActionCategory());
		tableCategory.setModel(DBConnector.selectAll("CATEGORY"));
		scrollerCategory.setPreferredSize(new Dimension(700, 200));
		downPanelCategory.add(scrollerCategory);
		tableCategory.addMouseListener(new TableMouseClickCategory());

		//------------------------------------------------------------------------- Records
		panelRecord.setLayout(new GridLayout(2,2));
		// ------------------------------ Left side
		tableRecordsLeft.setSelectionBackground(new Color(0,0,0));
		tableRecordsLeft.setSelectionForeground(new Color(255,255,255));
		//Label панели
		animalLabelRecordsLeft.setForeground(new Color(0,0,0));
		animalLabelRecordsLeft.setHorizontalAlignment(SwingConstants.CENTER);
		//ComboBox панели
		nameComboPets.setBackground(new Color(0,0,0));
		nameComboPets.setForeground(new Color(255,255,255));
		nameComboPets.setBorder(BorderFactory.createMatteBorder(0, 0, 0, 0, Color.black));
		nameComboCategory.setBackground(new Color(0,0,0));
		nameComboCategory.setForeground(new Color(255,255,255));
		nameComboCategory.setBorder(BorderFactory.createMatteBorder(0, 0, 0, 0, Color.black));
		//Кнопки
		addBtnRecordsLeft.setBackground(new Color(0,0,0));
		addBtnRecordsLeft.setForeground(new Color(255,255,255));
		addBtnRecordsLeft.setBorder(BorderFactory.createMatteBorder(4, 4, 4, 4, Color.black));
		delBtnRecordsLeft.setBackground(new Color(0,0,0));
		delBtnRecordsLeft.setForeground(new Color(255,255,255));
		delBtnRecordsLeft.setBorder(BorderFactory.createMatteBorder(4, 4, 4, 4, Color.black));
		searchBtnPetsLeft.setBackground(new Color(0,0,0));
		searchBtnPetsLeft.setForeground(new Color(255,255,255));
		searchBtnPetsLeft.setBorder(BorderFactory.createMatteBorder(4, 4, 4, 4, Color.black));
		searchBtnRecordsLeft.setBackground(new Color(0,0,0));
		searchBtnRecordsLeft.setForeground(new Color(255,255,255));
		searchBtnRecordsLeft.setBorder(BorderFactory.createMatteBorder(4, 4, 4, 4, Color.black));
		defaultBtnRecordsLeft.setBackground(new Color(0,0,0));
		defaultBtnRecordsLeft.setForeground(new Color(255,255,255));
		defaultBtnRecordsLeft.setBorder(BorderFactory.createMatteBorder(4, 4, 4, 4, Color.black));
		//--------------------------------------------
		panelRecord.add(upPanelRecordsLeft);
		panelRecord.add(downPanelRecordsLeft);
		JPanel upPanelRecordsLeft1 = new JPanel();
		JPanel upPanelRecordsLeft2 = new JPanel();
		upPanelRecordsLeft.setLayout(new GridLayout(1,1));
		upPanelRecordsLeft.add(upPanelRecordsLeft1);
		upPanelRecordsLeft.add(upPanelRecordsLeft2);
		upPanelRecordsLeft1.add(animalLabelRecordsLeft);
		fillNamesCombo();
		upPanelRecordsLeft1.add(nameComboPets);
		fillNamesComboCategory();
		upPanelRecordsLeft1.add(nameComboCategory);
		upPanelRecordsLeft2.add(addBtnRecordsLeft);
		addBtnRecordsLeft.addActionListener(new AddBtnRecordsLeft());
		upPanelRecordsLeft2.add(delBtnRecordsLeft);
		delBtnRecordsLeft.addActionListener(new DelBtnRecordsLeft());
		upPanelRecordsLeft2.add(searchBtnPetsLeft);
		searchBtnPetsLeft.addActionListener(new SearchBtnPetsLeft());
		upPanelRecordsLeft2.add(searchBtnRecordsLeft);
		searchBtnRecordsLeft.addActionListener(new SearchBtnRecordsLeft());
		upPanelRecordsLeft2.add(defaultBtnRecordsLeft);
		defaultBtnRecordsLeft.addActionListener(new DefaultBtnRecordsLeft());
		tableRecordsLeft.setModel(DBConnector.selectAllCombo("PETS", "PETSCATEGORY", "PETSID"));
		scrollerRecordsLeft.setPreferredSize(new Dimension(300,200));
		downPanelRecordsLeft.add(scrollerRecordsLeft);
		// ------------------------------ Right side
		tableRecordsRights.setSelectionBackground(new Color(0,0,0));
		tableRecordsRights.setSelectionForeground(new Color(255,255,255));
		//Label панели
		doctorsLabelRecordsRight.setForeground(new Color(0,0,0));
		doctorsLabelRecordsRight.setHorizontalAlignment(SwingConstants.CENTER);
		//ComboBox панели
		nameComboDoctors.setBackground(new Color(0,0,0));
		nameComboDoctors.setForeground(new Color(255,255,255));
		nameComboDoctors.setBorder(BorderFactory.createMatteBorder(0, 0, 0, 0, Color.black));
		nameComboCategory2.setBackground(new Color(0,0,0));
		nameComboCategory2.setForeground(new Color(255,255,255));
		nameComboCategory2.setBorder(BorderFactory.createMatteBorder(0, 0, 0, 0, Color.black));
		//Кнопки
		addBtnRecordsRight.setBackground(new Color(0,0,0));
		addBtnRecordsRight.setForeground(new Color(255,255,255));
		addBtnRecordsRight.setBorder(BorderFactory.createMatteBorder(4, 4, 4, 4, Color.black));
		delBtnRecordsRight.setBackground(new Color(0,0,0));
		delBtnRecordsRight.setForeground(new Color(255,255,255));
		delBtnRecordsRight.setBorder(BorderFactory.createMatteBorder(4, 4, 4, 4, Color.black));
		searchBtnDoctorsRight.setBackground(new Color(0,0,0));
		searchBtnDoctorsRight.setForeground(new Color(255,255,255));
		searchBtnDoctorsRight.setBorder(BorderFactory.createMatteBorder(4, 4, 4, 4, Color.black));
		searchBtnRecordsRight.setBackground(new Color(0,0,0));
		searchBtnRecordsRight.setForeground(new Color(255,255,255));
		searchBtnRecordsRight.setBorder(BorderFactory.createMatteBorder(4, 4, 4, 4, Color.black));
		defaultBtnRecordsRight.setBackground(new Color(0,0,0));
		defaultBtnRecordsRight.setForeground(new Color(255,255,255));
		defaultBtnRecordsRight.setBorder(BorderFactory.createMatteBorder(4, 4, 4, 4, Color.black));
		//--------------------------------------------
		JPanel upPanelRecordsRight1 = new JPanel();
		JPanel upPanelRecordsRight2 = new JPanel();
		panelRecord.add(upPanelRecordsRight);
		panelRecord.add(downPanelRecordsRight);
		upPanelRecordsRight.setLayout(new GridLayout(1,1));
		upPanelRecordsRight.add(upPanelRecordsRight1);
		upPanelRecordsRight.add(upPanelRecordsRight2);
		upPanelRecordsRight1.add(doctorsLabelRecordsRight);
		fillNamesComboDoctors();
		upPanelRecordsRight1.add(nameComboDoctors);
		fillNamesComboCategory2();
		upPanelRecordsRight1.add(nameComboCategory2);
		upPanelRecordsRight2.add(addBtnRecordsRight);
		addBtnRecordsRight.addActionListener(new AddBtnRecordsRight());
		upPanelRecordsRight2.add(delBtnRecordsRight);
		delBtnRecordsRight.addActionListener(new DelBtnRecordsRight());
		upPanelRecordsRight2.add(searchBtnDoctorsRight);
		searchBtnDoctorsRight.addActionListener(new SearchBtnDoctorsRight());
		upPanelRecordsRight2.add(searchBtnRecordsRight);
		searchBtnRecordsRight.addActionListener(new SearchBtnRecordsRight());
		upPanelRecordsRight2.add(defaultBtnRecordsRight);
		defaultBtnRecordsRight.addActionListener(new DefaultBtnRecordsRight());
		tableRecordsRights.setModel(DBConnector.selectAllCombo("DOCTORS", "DOCTORSCATEGORY", "DOCTORSID"));
		scrollerRecordsRight.setPreferredSize(new Dimension(300,200));
		downPanelRecordsRight.add(scrollerRecordsRight);
	}

    //--------------------------------------------------------- Поиск в БД
	class SearchBtnPetsLeft implements ActionListener{
		@Override
		public void actionPerformed(ActionEvent e) {
			String item = (String) nameComboPets.getSelectedItem();
			String add = item.substring(0, item.indexOf("."));
			int id = Integer.parseInt(add);
			idPets = id;
			tableRecordsLeft.setModel(DBConnector.selectSearchAllCombo("PETS", "PETSCATEGORY", "PETS", "PETSID", idPets));
		}		
	}

	class SearchBtnRecordsLeft implements ActionListener{
		@Override
		public void actionPerformed(ActionEvent e) {
			String item = (String) nameComboCategory.getSelectedItem();
			String add = item.substring(0, item.indexOf("."));
			int id = Integer.parseInt(add);
			idCategory = id;
			tableRecordsLeft.setModel(DBConnector.selectSearchAllCombo("PETS", "PETSCATEGORY", "CATEGORY", "PETSID", idCategory));
		}
	}

	class SearchBtnDoctorsRight implements ActionListener{
		@Override
		public void actionPerformed(ActionEvent e) {
			String item = (String) nameComboDoctors.getSelectedItem();
			String add = item.substring(0, item.indexOf("."));
			int id = Integer.parseInt(add);
			idDoctors = id;
			tableRecordsRights.setModel(DBConnector.selectSearchAllCombo("DOCTORS", "DOCTORSCATEGORY", "DOCTORS", "DOCTORSID", idDoctors));
		}
	}

	class SearchBtnRecordsRight implements ActionListener{
		@Override
		public void actionPerformed(ActionEvent e) {
			String item = (String) nameComboCategory2.getSelectedItem();
			String add = item.substring(0, item.indexOf("."));
			int id = Integer.parseInt(add);
			idCategory = id;
			tableRecordsRights.setModel(DBConnector.selectSearchAllCombo("DOCTORS", "DOCTORSCATEGORY", "CATEGORY", "DOCTORSID", idCategory));
		}
	}

	class SearchActionPets implements ActionListener{
		@Override
		public void actionPerformed(ActionEvent e) {
			String lname = lnameTFieldPets.getText();
			String age = ageTFieldPets.getText();

			if(SearchComboPets.getSelectedIndex()==0) {
				tablePets.setModel(DBConnector.selectSearch("PETS","FNAME", lname));
			}
			if(SearchComboPets.getSelectedIndex()==1) {
				tablePets.setModel(DBConnector.selectSearch("PETS","AGE", age));
			}
		}
	}

	class SearchActionDoctors implements ActionListener{
		@Override
		public void actionPerformed(ActionEvent e) {
			String fname = fnameTFieldDoctors.getText();
			String lname = lnameTFieldDoctors.getText();
			String age = ageTFieldDoctors.getText();

			if(SearchComboDoctors.getSelectedIndex()==0) {
				tableDoctors.setModel(DBConnector.selectSearch("DOCTORS","FNAME", fname));
			}
			if(SearchComboDoctors.getSelectedIndex()==1) {
				tableDoctors.setModel(DBConnector.selectSearch("DOCTORS","LNAME", lname));
			}
			if(SearchComboDoctors.getSelectedIndex()==2) {
				tableDoctors.setModel(DBConnector.selectSearch("DOCTORS","AGE", age));
			}
		}
	}

	//--------------------------------------------------------- Списки из БД
	public void fillNamesCombo() {
		ResultSet result = DBConnector.getAllFromTable("PETS");
		nameComboPets.removeAllItems();
		try {
			while(result.next()) {
				String comboElement = result.getObject(1).toString()
						+ ". " + result.getObject(2).toString()
						+ ", years - " + result.getObject(3);
				nameComboPets.addItem(comboElement);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public void fillNamesComboDoctors() {
		ResultSet result = DBConnector.getAllFromTable("DOCTORS");
		nameComboDoctors.removeAllItems();
		try {
			while(result.next()) {
				String comboElementDoctors = result.getObject(1).toString()
						+ ". Doc. - " + result.getObject(2).toString()
						+ " " + result.getObject(3);
				nameComboDoctors.addItem(comboElementDoctors);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public void fillNamesComboCategory() {
		ResultSet resultCategory = DBConnector.getAllFromTable("CATEGORY");
		nameComboCategory.removeAllItems();
		try {
			while(resultCategory.next()) {
				String comboElementCategory = resultCategory.getObject(1).toString()
						+ ". Category - " + resultCategory.getObject(2) + "  ";
				nameComboCategory.addItem(comboElementCategory);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public void fillNamesComboCategory2() {
		ResultSet resultCategory = DBConnector.getAllFromTable("CATEGORY");
		nameComboCategory2.removeAllItems();
		try {
			while(resultCategory.next()) {
				String comboElementCategory = resultCategory.getObject(1).toString()
						+ ". Category - " + resultCategory.getObject(2) + "   ";
				nameComboCategory2.addItem(comboElementCategory);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	//--------------------------------------------------------- Редактирование БД
	class EditActionPets implements ActionListener{
		@Override
		public void actionPerformed(ActionEvent e) {
			String lname = lnameTFieldPets.getText();
			String age = ageTFieldPets.getText();
			String gender;
			if(genderComboPets.getSelectedIndex() == 0) {
				gender = "Man";
			}else {
				gender = "Woman";
			}
			DBConnector.UpdateFromTable("PETS", "FNAME", lname, idPets);
			DBConnector.UpdateFromTable("PETS", "AGE", age, idPets);
			DBConnector.UpdateFromTable("PETS", "GENDER ", gender, idPets);
			tablePets.setModel(DBConnector.selectAll("PETS"));
		}
	}

	class EditActionDoctors implements ActionListener{
		@Override
		public void actionPerformed(ActionEvent e) {
			String fname = fnameTFieldDoctors.getText();
			String lname = lnameTFieldDoctors.getText();
			String age = ageTFieldDoctors.getText();
			String gender;
			if(genderComboDoctors.getSelectedIndex() == 0) {
				gender = "Man";
			}else {
				gender = "Woman";
			}
			DBConnector.UpdateFromTable("DOCTORS", "FNAME", fname, idDoctors);
			DBConnector.UpdateFromTable("DOCTORS", "lNAME", lname, idDoctors);
			DBConnector.UpdateFromTable("DOCTORS", "AGE", age, idDoctors);
			DBConnector.UpdateFromTable("DOCTORS", "GENDER ", gender, idDoctors);
			tableDoctors.setModel(DBConnector.selectAll("DOCTORS"));
		}
	}

	class EditActionCategory implements ActionListener{
		@Override
		public void actionPerformed(ActionEvent e) {
			String name = nameTFieldCategory.getText();
			DBConnector.UpdateFromTable("CATEGORY", "CATEGORY", name, idCategory);
			tableCategory.setModel(DBConnector.selectAll("CATEGORY"));
		}
	}
	//--------------------------------------------------------- Добавление животного и доктора
	class AddBtnRecordsLeft implements ActionListener{
		@Override
		public void actionPerformed(ActionEvent e) {
			String item = (String) nameComboPets.getSelectedItem();
			String addCategory = item.substring(0, item.indexOf("."));
			int id1 = Integer.parseInt(addCategory);
			idPets = id1;

			String item1 = (String)  nameComboCategory.getSelectedItem();
			String addCategory1 = item1.substring(0, item1.indexOf("."));
			int id2 = Integer.parseInt(addCategory1);
			idCategory = id2;

			String sql = "INSERT INTO PETSCATEGORY VALUES(null,?,?);";
			conn = DBConnector.getConnection();
			try {
				state = conn.prepareStatement(sql);
				state.setString(1, addCategory);
				state.setString(2, addCategory1);
				state.execute();
				tableRecordsLeft.setModel(DBConnector.selectAllCombo("PETS", "PETSCATEGORY", "PETSID"));
				clearFormCategory();
			} catch (SQLException e1) {
				e1.printStackTrace();
			}
		}
	}

	class AddBtnRecordsRight implements ActionListener{
		@Override
		public void actionPerformed(ActionEvent e) {
			String item = (String) nameComboDoctors.getSelectedItem();
			String addCategory = item.substring(0, item.indexOf("."));
			int id1 = Integer.parseInt(addCategory);
			idDoctors = id1;

			String item1 = (String)  nameComboCategory2.getSelectedItem();
			String addCategory1 = item1.substring(0, item1.indexOf("."));
			int id2 = Integer.parseInt(addCategory1);
			idCategory = id2;

			String sql = "INSERT INTO DOCTORSCATEGORY VALUES(null,?,?);";
			conn = DBConnector.getConnection();
			try {
				state = conn.prepareStatement(sql);
				state.setString(1, addCategory);
				state.setString(2, addCategory1);
				state.execute();
				tableRecordsRights.setModel(DBConnector.selectAllCombo("DOCTORS", "DOCTORSCATEGORY", "DOCTORSID"));
				clearFormCategory();
			} catch (SQLException e1) {
				e1.printStackTrace();
			}
		}
	}

	class AddActionPets implements ActionListener{
		@Override
		public void actionPerformed(ActionEvent e) {
			String lname = lnameTFieldPets.getText();
			int age = Integer.parseInt(ageTFieldPets.getText());
			String gender;
			if(genderComboPets.getSelectedIndex() == 0) {
				gender = "Woman";
			}else {
				gender = "Man";
			}

			String sql = "INSERT INTO PETS VALUES(null,?,?,?);";
			conn = DBConnector.getConnection();
			try {
				state = conn.prepareStatement(sql);
				state.setString(1, lname);
				state.setInt(2, age);
				state.setString(3, gender);
				state.execute();
				tablePets.setModel(DBConnector.selectAll("PETS"));
				fillNamesCombo();
				clearForm();
			} catch (SQLException e1) {
				e1.printStackTrace();
			}
		}
	}

	class AddActionDoctors implements ActionListener{
		@Override
		public void actionPerformed(ActionEvent e) {
			String fname = fnameTFieldDoctors.getText();
			String lname = lnameTFieldDoctors.getText();
			int age = Integer.parseInt(ageTFieldDoctors.getText());
			String gender;
			if(genderComboDoctors.getSelectedIndex() == 0) {
				gender = "Woman";
			}else {
				gender = "Man";
			}

			String sql = "INSERT INTO DOCTORS VALUES(null,?,?,?,?);";
			conn = DBConnector.getConnection();
			try {
				state = conn.prepareStatement(sql);
				state.setString(1, fname);
				state.setString(2, lname);
				state.setInt(3, age);
				state.setString(4, gender);
				state.execute();
				tableDoctors.setModel(DBConnector.selectAll("DOCTORS"));
				fillNamesComboDoctors();
				clearFormDoctors();
			} catch (SQLException e1) {
				e1.printStackTrace();
			}
		}
	}

	class AddActionCategory implements ActionListener{
		@Override
		public void actionPerformed(ActionEvent e) {
			String name = nameTFieldCategory.getText();

			String sql = "INSERT INTO CATEGORY VALUES(null,?);";
			conn = DBConnector.getConnection();
			try {
				state = conn.prepareStatement(sql);
				state.setString(1, name);
				state.execute();
				tableCategory.setModel(DBConnector.selectAll("CATEGORY"));
				fillNamesComboCategory();
				fillNamesComboCategory2();
				clearFormCategory();
			} catch (SQLException e1) {
				e1.printStackTrace();
			}
		}
	}
	//--------------------------------------------------------- Отслеживания клика по таблице для назначения данных строкам
	class TableMouseClick extends MouseAdapter{
		@Override
		public void mouseClicked(MouseEvent e) {
			int row = tablePets.getSelectedRow();
			Object value = tablePets.getValueAt(row, 0);
			idPets = Integer.parseInt(value.toString());
			if (e.getClickCount() > 1) {
				lnameTFieldPets.setText(tablePets.getValueAt(row, 1).toString());
				ageTFieldPets.setText(tablePets.getValueAt(row, 2).toString());
				if (tablePets.getValueAt(row, 3).toString().equals("Woman")) {
					genderComboPets.setSelectedIndex(1);
				} else {
					genderComboPets.setSelectedIndex(0);
				}
			}

			if (SwingUtilities.isRightMouseButton(e)) {
				MyPopUpMenu menu = new MyPopUpMenu(idPets);
				menu.show(tablePets, e.getX(), e.getY());
			}
		}
	}

	class TableMouseClickDoctors extends MouseAdapter{
		@Override
		public void mouseClicked(MouseEvent e) {
			int row = tableDoctors.getSelectedRow();
			Object value = tableDoctors.getValueAt(row, 0);
			idDoctors = Integer.parseInt(value.toString());

			if (e.getClickCount() > 1) {
				fnameTFieldDoctors.setText(tableDoctors.getValueAt(row, 1).toString());
				lnameTFieldDoctors.setText(tableDoctors.getValueAt(row, 2).toString());
				ageTFieldDoctors.setText(tableDoctors.getValueAt(row, 3).toString());

				if (tableDoctors.getValueAt(row, 4).toString().equals("Woman")) {
					genderComboDoctors.setSelectedIndex(1);
				} else {
					genderComboDoctors.setSelectedIndex(0);
				}
			}
			if (SwingUtilities.isRightMouseButton(e)) {
				MyPopUpMenu menu = new MyPopUpMenu(idDoctors);
				menu.show(tableDoctors, e.getX(), e.getY());
			}
		}
	}

	class TableMouseClickCategory extends MouseAdapter{
		@Override
		public void mouseClicked(MouseEvent e) {
			int row = tableCategory.getSelectedRow();
			Object value = tableCategory.getValueAt(row, 0);
			idCategory = Integer.parseInt(value.toString());

			if (e.getClickCount() > 1) {
				nameTFieldCategory.setText(tableCategory.getValueAt(row, 1).toString());
			}

			if (SwingUtilities.isRightMouseButton(e)) {
				MyPopUpMenu menu = new MyPopUpMenu(idCategory);
				menu.show(tableCategory, e.getX(), e.getY());
			}
		}
	}

	//--------------------------------------------------------- Удаление из БД
	//Удаляет строчку в таблице животные и животные категории по id
	class DelActionPets implements ActionListener{
		@Override
		public void actionPerformed(ActionEvent e) {
			DBConnector.deleteRow("PETS","ID" ,idPets);
			DBConnector.deleteRow("PETSCATEGORY","PETSID",idPets);
			fillNamesCombo();
			tablePets.setModel(DBConnector.selectAll("PETS"));
			idPets = -1;
		}
	}
	//Удаляет строчку в таблице докторс и докторс категории по id
	class DelActionDoctors implements ActionListener{
		@Override
		public void actionPerformed(ActionEvent e) {
			DBConnector.deleteRow("DOCTORS","ID" ,idDoctors);
			DBConnector.deleteRow("DOCTORSCATEGORY","DOCTORSID",idDoctors);
			fillNamesComboDoctors();
			tableDoctors.setModel(DBConnector.selectAll("DOCTORS"));
			idDoctors = -1;
		}
	}
	//Удаляет строчку в таблице категории и докторс категории и животные категории по id
	class DelActionCategory implements ActionListener{
		@Override
		public void actionPerformed(ActionEvent e) {
			DBConnector.deleteRow("CATEGORY","ID" ,idCategory);
			DBConnector.deleteRow("DOCTORSCATEGORY","CATEGORYID",idCategory);
			DBConnector.deleteRow("PETSCATEGORY","CATEGORYID",idCategory);
			fillNamesComboCategory();
			fillNamesComboCategory2();
			tableCategory.setModel(DBConnector.selectAll("CATEGORY"));
			idCategory = -1;
		}
	}
	//Удаляет с левой таблицы строчку
	class DelBtnRecordsLeft implements ActionListener{
		@Override
		public void actionPerformed(ActionEvent e) {
			String item = (String) nameComboPets.getSelectedItem();
			String delStr = item.substring(0, item.indexOf("."));
			int id1 = Integer.parseInt(delStr);
			idPets = id1;

			String itemCategory = (String) nameComboCategory.getSelectedItem();
			String delStrCategory = itemCategory.substring(0, itemCategory.indexOf("."));
			int id2 = Integer.parseInt(delStrCategory);
			idCategory = id2;

			DBConnector.deleteRowCombo("PETSCATEGORY","PETSID","CATEGORYID", idPets, idCategory);
			tableRecordsLeft.setModel(DBConnector.selectAllCombo("PETS", "PETSCATEGORY", "PETSID"));
		}
	}
	//Удаляет с правой таблицы строчку
	class DelBtnRecordsRight implements ActionListener{
		@Override
		public void actionPerformed(ActionEvent e) {
			String item = (String) nameComboDoctors.getSelectedItem();
			String delStr = item.substring(0, item.indexOf("."));
			int id1 = Integer.parseInt(delStr);
			idDoctors = id1;

			String itemCategory = (String) nameComboCategory2.getSelectedItem();
			String delStrCategory = itemCategory.substring(0, itemCategory.indexOf("."));
			int id2 = Integer.parseInt(delStrCategory);
			idCategory=id2;

			DBConnector.deleteRowCombo("DOCTORSCATEGORY","DOCTORSID","CATEGORYID", idDoctors, idCategory);
			tableRecordsRights.setModel(DBConnector.selectAllCombo("DOCTORS", "DOCTORSCATEGORY", "DOCTORSID"));
		}
	}

	//--------------------------------------------------------- Defaults status
	class DefaultBtnRecordsLeft implements ActionListener{
		@Override
		public void actionPerformed(ActionEvent e) {
			tableRecordsLeft.setModel(DBConnector.selectAllCombo("PETS", "PETSCATEGORY", "PETSID"));
		}
	}

	class DefaultBtnRecordsRight implements ActionListener{
		@Override
		public void actionPerformed(ActionEvent e) {
			tableRecordsRights.setModel(DBConnector.selectAllCombo("DOCTORS", "DOCTORSCATEGORY", "DOCTORSID"));
		}
	}

	//--------------------------------------------------------- Обновление таблиц
	public void clearForm() {
		lnameTFieldPets.setText("");
		ageTFieldPets.setText("");
	}

	public void clearFormDoctors() {
		fnameTFieldDoctors.setText("");
		lnameTFieldDoctors.setText("");
		ageTFieldDoctors.setText("");
	}

	public void clearFormCategory() {
		nameTFieldCategory.setText("");
	}
}