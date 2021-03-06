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

public class MenuView {

	private JFrame frmMenu;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			@Override
			public void run() {
				try {
					MenuView window = new MenuView();
					window.frmMenu.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public MenuView() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frmMenu = new JFrame();
		frmMenu.setTitle("Menu");
		frmMenu.setBounds(100, 100, 450, 300);
		frmMenu.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

		JLabel lbTitre = new JLabel("Menu");
		lbTitre.setFont(new Font("Source Sans Pro Semibold", Font.PLAIN, 18));
		lbTitre.setHorizontalAlignment(SwingConstants.CENTER);

		JButton btnCateg = new JButton("Cat\u00E9gories");
		btnCateg.addActionListener(new ActionListener() {
			@Override
			public void actionPerformed(ActionEvent arg0) {
				frmMenu.dispose();
				new CategView();
			}
		});

		JButton btnCritere = new JButton("Crit\u00E8res");

		JButton btnUtilisateur = new JButton("Utilisateurs");

		JButton btnRetour = new JButton("Retour");
		GroupLayout groupLayout = new GroupLayout(frmMenu.getContentPane());
		groupLayout.setHorizontalGroup(groupLayout.createParallelGroup(Alignment.LEADING)
				.addComponent(lbTitre, GroupLayout.DEFAULT_SIZE, 434, Short.MAX_VALUE)
				.addGroup(groupLayout.createSequentialGroup().addGap(154)
						.addComponent(btnCateg, GroupLayout.DEFAULT_SIZE, 123, Short.MAX_VALUE).addGap(157))
				.addGroup(groupLayout.createSequentialGroup().addGap(154)
						.addComponent(btnCritere, GroupLayout.DEFAULT_SIZE, 123, Short.MAX_VALUE).addGap(157))
				.addGroup(groupLayout.createSequentialGroup().addGap(154)
						.addComponent(btnUtilisateur, GroupLayout.DEFAULT_SIZE, 123, Short.MAX_VALUE).addGap(157))
				.addGroup(Alignment.TRAILING, groupLayout.createSequentialGroup().addGap(345).addComponent(btnRetour,
						GroupLayout.PREFERRED_SIZE, 89, GroupLayout.PREFERRED_SIZE)));
		groupLayout.setVerticalGroup(groupLayout.createParallelGroup(Alignment.LEADING)
				.addGroup(groupLayout.createSequentialGroup().addComponent(lbTitre).addGap(36)
						.addComponent(btnCateg, GroupLayout.PREFERRED_SIZE, 38, GroupLayout.PREFERRED_SIZE).addGap(21)
						.addComponent(btnCritere, GroupLayout.PREFERRED_SIZE, 38, GroupLayout.PREFERRED_SIZE).addGap(22)
						.addComponent(btnUtilisateur, GroupLayout.PREFERRED_SIZE, 38, GroupLayout.PREFERRED_SIZE)
						.addGap(22).addComponent(btnRetour)));
		frmMenu.getContentPane().setLayout(groupLayout);

		frmMenu.setVisible(true);

		btnRetour.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent arg0) {
				frmMenu.dispose();
				new AuthentificationView();
			}
		});
	}

}
