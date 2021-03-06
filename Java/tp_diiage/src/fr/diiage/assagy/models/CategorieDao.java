package fr.diiage.assagy.models;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;

import fr.diiage.assagy.entities.Categorie;

public class CategorieDao {

	// CREATE CATEGORIE
	public static void createCategorie(Categorie categorie) {
		try {

			String sql = "INSERT INTO category (ID, DESCRIPTION) VALUES(?, ?)";
			PreparedStatement stmt = DaoConnect.getConnection().prepareStatement(sql);
			stmt.setInt(1, categorie.getId());
			stmt.setString(2, categorie.getLibelle()); // dans le premier ? je lui met le libelle
			stmt.executeUpdate();
		} catch (SQLException e) {
			// e.printStackTrace();
			System.out.println("Erreur");
		} finally {
			DaoConnect.closeConnection();
		}
	}

	// READ CATEGORIE
	public static ArrayList<Categorie> getCategories() {
		ArrayList<Categorie> categories = new ArrayList<Categorie>();
		try {

			String sql = "SELECT * FROM category";
			Statement stmt = DaoConnect.getConnection().createStatement();
			ResultSet rs = stmt.executeQuery(sql);
			while (rs.next()) {
				categories.add(new Categorie(rs.getInt("id"), rs.getString("description")));
			}
		} catch (SQLException e) {
			e.printStackTrace();
		} finally {
			DaoConnect.closeConnection();
		}
		return categories;
	}

	// UPDATE CATEGORIE
	public static void updateCategorie(Categorie categorie) {
		try {

			String sql = "UPDATE category SET description = ? WHERE id = ?";
			PreparedStatement stmt = DaoConnect.getConnection().prepareStatement(sql);
			stmt.setString(1, categorie.getLibelle());
			stmt.setInt(2, categorie.getId());
			stmt.executeUpdate();
		} catch (SQLException e) {
			// e.printStackTrace();
			System.out.println("Erreur");
		} finally {
			DaoConnect.closeConnection();
		}
	}

	// DELETE CATEGORIE
	public static void deleteCategorie(Categorie categorie) {
		try {

			String sql = "DELETE FROM category WHERE id = ?";
			PreparedStatement stmt = DaoConnect.getConnection().prepareStatement(sql);
			stmt.setInt(1, categorie.getId());
			stmt.executeUpdate();
		} catch (SQLException e) {
			// e.printStackTrace();
			System.out.println("Erreur");
		} finally {
			DaoConnect.closeConnection();
		}
	}

}
