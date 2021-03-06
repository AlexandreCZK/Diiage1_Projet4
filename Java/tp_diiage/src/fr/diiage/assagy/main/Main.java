package fr.diiage.assagy.main;

import java.sql.Connection;
import java.util.ArrayList;

import fr.diiage.assagy.entities.Categorie;
import fr.diiage.assagy.models.CategorieDao;
import fr.diiage.assagy.models.DaoConnect;

public class Main {
	public static ArrayList<Categorie> categories;

	public static void main(String[] args) {
		categories = new ArrayList<Categorie>();
		// Connection bdd
		Connection conn = DaoConnect.getConnection();
		System.out.println("ok");

		// Création des catégories et ArrayList
		// Categorie categorie1 = new Categorie(1, "U18");
		// Categorie categorie2 = new Categorie(2, "U17");
		Categorie categorie3 = new Categorie(3, "U16");
		ArrayList<Categorie> lesCategs = new ArrayList<Categorie>();

		// Insertion categories + recup ArrayList
		// CategorieDao.createCategorie(categorie1);
		// CategorieDao.createCategorie(categorie2);
		// CategorieDao.createCategorie(categorie3);
		lesCategs = CategorieDao.getCategories();

		// Parcours de l'arrayList
		// for (Categorie categ : lesCategs) {
		// System.out.println(categ.getLibelle() + " " + categ.getId());
		// }
		// ;

		// Modification de categorie 3 DOIT AVOIR UN ID
		// categorie3.setLibelle("U19");
		// CategorieDao.updateCategorie(categorie3);
		// System.out.println(categorie3.getLibelle());
		CategorieDao.deleteCategorie(categorie3);

		// new AuthentificationView();

	}

}
