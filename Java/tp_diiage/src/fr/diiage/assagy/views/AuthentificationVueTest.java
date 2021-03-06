package fr.diiage.assagy.views;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JCheckBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPasswordField;
import javax.swing.JTextField;

public class AuthentificationVueTest {

	private JFrame frame;
	private final JPasswordField passwordField = new JPasswordField();
	private JTextField textField;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			@Override
			public void run() {
				try {
					AuthentificationVueTest window = new AuthentificationVueTest();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public AuthentificationVueTest() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 450, 300);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

		JLabel lblNewLabel = new JLabel("Authentification");
		frame.getContentPane().add(lblNewLabel, BorderLayout.NORTH);

		JCheckBox chckbxNewCheckBox = new JCheckBox("New check box");
		frame.getContentPane().add(chckbxNewCheckBox, BorderLayout.WEST);
		frame.getContentPane().add(passwordField, BorderLayout.CENTER);

		textField = new JTextField();
		frame.getContentPane().add(textField, BorderLayout.SOUTH);
		textField.setColumns(10);
	}

}
