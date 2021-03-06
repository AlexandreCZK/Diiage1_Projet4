package fr.diiage.assagy.views;

import java.awt.EventQueue;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.GroupLayout;
import javax.swing.GroupLayout.Alignment;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.SwingConstants;

public class CategView {

	private JFrame frmCateg;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			@Override
			public void run() {
				try {
					CategView window = new CategView();
					window.frmCateg.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public CategView() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frmCateg = new JFrame();
		frmCateg.setTitle("Cat\u00E9gorie");
		frmCateg.setBounds(100, 100, 450, 300);
		frmCateg.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

		JLabel lbTitre = new JLabel("Cat\u00E9gorie");
		lbTitre.setHorizontalAlignment(SwingConstants.CENTER);
		lbTitre.setFont(new Font("Source Sans Pro Semibold", Font.PLAIN, 18));

		JButton btnCreer = new JButton("Cr\u00E9er");

		JButton btnModif = new JButton("Modifier");

		JButton btnSuppr = new JButton("Supprimer");

		JButton btnRetour = new JButton("Retour");
		btnRetour.addActionListener(new ActionListener() {
			@Override
			public void actionPerformed(ActionEvent arg0) {
				frmCateg.dispose();
				new MenuView();
			}
		});
		GroupLayout groupLayout = new GroupLayout(frmCateg.getContentPane());
		groupLayout.setHorizontalGroup(groupLayout.createParallelGroup(Alignment.LEADING)
				.addGroup(groupLayout.createSequentialGroup().addGap(165)
						.addComponent(lbTitre, GroupLayout.DEFAULT_SIZE, 82, Short.MAX_VALUE).addGap(187))
				.addGroup(groupLayout.createSequentialGroup().addGap(146)
						.addComponent(btnCreer, GroupLayout.DEFAULT_SIZE, 123, Short.MAX_VALUE).addGap(165))
				.addGroup(groupLayout.createSequentialGroup().addGap(146)
						.addComponent(btnModif, GroupLayout.DEFAULT_SIZE, 123, Short.MAX_VALUE).addGap(165))
				.addGroup(groupLayout.createSequentialGroup().addGap(146)
						.addComponent(btnSuppr, GroupLayout.DEFAULT_SIZE, 123, Short.MAX_VALUE).addGap(165))
				.addGroup(Alignment.TRAILING, groupLayout.createSequentialGroup().addGap(345).addComponent(btnRetour,
						GroupLayout.PREFERRED_SIZE, 89, GroupLayout.PREFERRED_SIZE)));
		groupLayout.setVerticalGroup(groupLayout.createParallelGroup(Alignment.LEADING)
				.addGroup(groupLayout.createSequentialGroup().addComponent(lbTitre).addGap(31)
						.addComponent(btnCreer, GroupLayout.PREFERRED_SIZE, 38, GroupLayout.PREFERRED_SIZE).addGap(23)
						.addComponent(btnModif, GroupLayout.PREFERRED_SIZE, 38, GroupLayout.PREFERRED_SIZE).addGap(22)
						.addComponent(btnSuppr, GroupLayout.PREFERRED_SIZE, 38, GroupLayout.PREFERRED_SIZE).addGap(25)
						.addComponent(btnRetour)));
		frmCateg.getContentPane().setLayout(groupLayout);

		frmCateg.setVisible(true);
	}

}
