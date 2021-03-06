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
import javax.swing.JTextField;
import javax.swing.SwingConstants;

public class AuthentificationView {

	private JFrame frmAuthentification;
	private JTextField tfPseudo;
	private JTextField tfMdp;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			@Override
			public void run() {
				try {
					AuthentificationView window = new AuthentificationView();
					window.frmAuthentification.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public AuthentificationView() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frmAuthentification = new JFrame();
		frmAuthentification.setTitle("Authentification");
		frmAuthentification.setBounds(100, 100, 450, 300);
		frmAuthentification.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

		JLabel lbTitre = new JLabel("Page d'authentification");
		lbTitre.setFont(new Font("Source Sans Pro Semibold", Font.PLAIN, 18));
		lbTitre.setHorizontalAlignment(SwingConstants.CENTER);

		tfPseudo = new JTextField();
		tfPseudo.setHorizontalAlignment(SwingConstants.CENTER);
		tfPseudo.setColumns(10);

		JLabel lbPseudo = new JLabel("Pseudo :");
		lbPseudo.setFont(new Font("Tahoma", Font.PLAIN, 14));

		JLabel lbMdp = new JLabel("Mot de passe :");
		lbMdp.setFont(new Font("Tahoma", Font.PLAIN, 14));

		tfMdp = new JTextField();
		tfMdp.setColumns(10);

		JButton btnConnection = new JButton("Se connecter");
		GroupLayout groupLayout = new GroupLayout(frmAuthentification.getContentPane());
		groupLayout.setHorizontalGroup(groupLayout.createParallelGroup(Alignment.LEADING)
				.addComponent(lbTitre, GroupLayout.DEFAULT_SIZE, 434, Short.MAX_VALUE)
				.addGroup(groupLayout.createSequentialGroup().addGap(125)
						.addComponent(lbPseudo, GroupLayout.DEFAULT_SIZE, 54, Short.MAX_VALUE).addGap(10)
						.addComponent(tfPseudo, GroupLayout.DEFAULT_SIZE, 137, Short.MAX_VALUE).addGap(108))
				.addGroup(groupLayout.createSequentialGroup().addGap(90)
						.addComponent(lbMdp, GroupLayout.DEFAULT_SIZE, 89, Short.MAX_VALUE).addGap(10)
						.addComponent(tfMdp, GroupLayout.DEFAULT_SIZE, 137, Short.MAX_VALUE).addGap(108))
				.addGroup(groupLayout.createSequentialGroup().addGap(155)
						.addComponent(btnConnection, GroupLayout.DEFAULT_SIZE, 123, Short.MAX_VALUE).addGap(156)));
		groupLayout.setVerticalGroup(groupLayout.createParallelGroup(Alignment.LEADING)
				.addGroup(groupLayout.createSequentialGroup()
						.addComponent(lbTitre, GroupLayout.PREFERRED_SIZE, 36, GroupLayout.PREFERRED_SIZE).addGap(50)
						.addGroup(groupLayout.createParallelGroup(Alignment.LEADING)
								.addGroup(groupLayout.createSequentialGroup().addGap(1).addComponent(lbPseudo,
										GroupLayout.PREFERRED_SIZE, 14, GroupLayout.PREFERRED_SIZE))
								.addComponent(tfPseudo, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE,
										GroupLayout.PREFERRED_SIZE))
						.addGap(34)
						.addGroup(groupLayout.createParallelGroup(Alignment.LEADING)
								.addGroup(groupLayout.createSequentialGroup().addGap(1).addComponent(lbMdp,
										GroupLayout.PREFERRED_SIZE, 19, GroupLayout.PREFERRED_SIZE))
								.addComponent(tfMdp, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE,
										GroupLayout.PREFERRED_SIZE))
						.addGap(67).addComponent(btnConnection)));
		frmAuthentification.getContentPane().setLayout(groupLayout);

		btnConnection.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent arg0) {
				frmAuthentification.dispose();
				new MenuView();
			}
		});

		frmAuthentification.setVisible(true);
		frmAuthentification.pack();
	}
}
