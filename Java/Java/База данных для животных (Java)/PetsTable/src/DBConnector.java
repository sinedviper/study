import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class DBConnector {
	
	private static Connection conn = null;
	
	public static Connection getConnection() {
		
		try {
			Class.forName("org.h2.Driver");
			conn = DriverManager.getConnection("jdbc:h2:I:\\Tasks\\PracticeOOPandDB\\PetsDB;AUTO_SERVER=TRUE", "sa", "sa");
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return conn;
	}
	//Выбрать в таблице все
	public static MyModel selectAll(String name) {
	
		MyModel model = null;
		try {
			model = new MyModel(getAllFromTable(name));
		} catch (Exception e) {
			e.printStackTrace();
		}
		return model;
	}
    //Выбирает определенные данные из таблиц
	public static MyModel selectAllCombo(String name1, String name2, String id) {

		MyModel model = null;
		try {
			model = new MyModel(getAllComboTable(name1, name2, id));
		} catch (Exception e) {
			e.printStackTrace();
		}
		return model;
	}
	//Выбирает данные со смежных таблиц
	public static MyModel selectSearchAllCombo(String name1, String name2, String name3, String id1, int id2) {

		MyModel model = null;
		try {
			model = new MyModel(getAllSearchCombo(name1, name2, name3, id1, id2 ));
		} catch (Exception e) {
			e.printStackTrace();
		}
		return model;
	}

	//Отображает все строки таблицы
	public static ResultSet getAllFromTable(String name) {
		String sql = "SELECT * FROM " + name;
		conn = getConnection();
		ResultSet result = null;
		
		try {
			PreparedStatement state = conn.prepareStatement(sql);
			result = state.executeQuery();
		} catch (SQLException e) {
			e.printStackTrace();
		} catch (Exception e) {
			e.printStackTrace();
		}
		
		return result;
	}
	//Отображает определенные данные из таблиц
	public static ResultSet getAllComboTable(String name1, String name2, String id) {
		String sql = "SELECT FNAME, CATEGORY FROM " + name1 + ", " + name2 + ", CATEGORY WHERE "+ name1 +".ID = "+ name2 +"."+id+" AND CATEGORY.ID = "+ name2 +".CATEGORYID";
		conn = getConnection();
		ResultSet result = null;

		try {
			PreparedStatement state = conn.prepareStatement(sql);
			result = state.executeQuery();
		} catch (SQLException e) {
			e.printStackTrace();
		} catch (Exception e) {
			e.printStackTrace();
		}
		return result;
	}
	//Отобразить данные выбранные в комбобоксе records
	public static ResultSet getAllSearchCombo(String name1, String name2, String name3, String id1, int id2) {
		String sql = "SELECT FNAME, CATEGORY FROM " + name1+", "+ name2 + ", CATEGORY WHERE "+ name1 + ".ID = " + name2 +"."+ id1 +" AND CATEGORY.ID = " + name2 + ".CATEGORYID AND " + name3 +".ID=" + id2;
		conn = getConnection();
		ResultSet result = null;

		try {
			PreparedStatement state = conn.prepareStatement(sql);
			result = state.executeQuery();
		} catch (SQLException e) {
			e.printStackTrace();
		} catch (Exception e) {
			e.printStackTrace();
		}
		return result;
	}
	//Отображает по заданному критерию строку
	public static MyModel selectSearch(String name, String str, String str1) {

		MyModel model = null;
		try {
			model = new MyModel(getAllSearchTable(name, str, str1));
		} catch (Exception e) {
			e.printStackTrace();
		}
		return model;
	}
	//Обоновляет в таблице данные
	public static ResultSet UpdateFromTable(String name, String str1, String str2, int id) {
		String sql = "UPDATE " + name +" SET "+ str1 + "=\'"+ str2 +"\' WHERE ID="+id;
		conn = getConnection();
		ResultSet result = null;

		try {
			PreparedStatement state = conn.prepareStatement(sql);
			state.executeUpdate();
		} catch (SQLException e) {
			e.printStackTrace();
		} catch (Exception e) {
			e.printStackTrace();
		}
		return result;
	}

	//Отображает по заданному критерию строку
	public static ResultSet getAllSearchTable(String name, String str1, String str2) {
		String sql = "SELECT * FROM " + name +" WHERE "+ str1 + " LIKE \'%"+str2+"%\'";
		conn = getConnection();
		ResultSet result = null;

		try {
			PreparedStatement state = conn.prepareStatement(sql);
			result = state.executeQuery();
		} catch (SQLException e) {
			e.printStackTrace();
		} catch (Exception e) {
			e.printStackTrace();
		}
		return result;
	}
	//удаляет выбранную строку
	public static void deleteRow(String name, String str ,int id) {
		String sql = "DELETE FROM " + name + " WHERE " + str + "=?";
		conn = DBConnector.getConnection();
		PreparedStatement state = null;
		try {
			state = conn.prepareStatement(sql);
			state.setInt(1, id);
			state.execute();
		} catch (SQLException e1) {
			e1.printStackTrace();
		}
	}
	//удаляем из всех таблиц строку в records
	public static void deleteRowCombo(String name, String str1, String str2, int id1, int id2) {
		String sql = "DELETE FROM " + name + " WHERE "	+ str1 +"=? AND "+ str2 +"=?";
		conn = DBConnector.getConnection();
		PreparedStatement state = null;
		try {
			state = conn.prepareStatement(sql);
			state.setInt(1, id1);
			state.setInt(2, id2);
			state.execute();
		} catch (SQLException e1) {
			e1.printStackTrace();
		}
	}
}