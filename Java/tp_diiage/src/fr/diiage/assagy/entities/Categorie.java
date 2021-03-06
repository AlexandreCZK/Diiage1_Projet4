package fr.diiage.assagy.entities;

public class Categorie {

	int id;
	String libelle;

	// Constructeur avec id
	public Categorie(int id, String libelle) {
		super();
		this.id = id;
		this.libelle = libelle;
	}

	// Constructeur sans id (depuis l'interface)
	public Categorie(String libelle) {
		super();
		this.libelle = libelle;
	}

	// getter et setter id
	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	// getter et setter libelle
	public String getLibelle() {
		return libelle;
	}

	public void setLibelle(String libelle) {
		this.libelle = libelle;
	}

	@Override
	public String toString() {
		return this.id + " " + this.libelle;
	}

}
