
package Formularios;

import Clases.Conexion;
import datechooser.beans.DateChooserCombo;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.Calendar;
import javax.swing.JOptionPane;

public class RegistroClientes extends javax.swing.JFrame {
    Conexion con = new Conexion();
    public static Connection conec = null;
    public static Statement st = null;
    public static ResultSet rs = null;
    public String sql = null;
    
    public RegistroClientes() {
        initComponents();
        Cargar();
        //MostrarDistrito();
    }
    
    public void Cargar(){
        String sql = "SELECT * FROM tblcliente";
        //String sexo=null;
        try {
            conec = con.Conectar();
            st = conec.createStatement();
            rs = st.executeQuery(sql);
            rs.first();
            Llenar();
            //DateChooserCombo setText = jdFecha.setText(rs.getDateFormatString(9));
            //año = dateFecha.fec.YEAR).rs.getCalendar(9);
           // mes = dateFecha.get(Calendar.MONTH).rs.getCalendar(9);
            //dia = dateFecha.get(Calendar.DAY_OF_MONTH).rs.getCalendar(9);
            //cboDistrito.addItem(rs.getString("Nom_Distrito"));
            //sexo = rs.getString(7);
            //if (sexo.compareTo("M")==0){
              //  cboSexo.setSelectedIndex(1);
            //} else {
              //  cboSexo.setSelectedIndex(2);
            //}
        } catch (Exception e){
            JOptionPane.showMessageDialog(null, e);
        }
    }
    public void Llenar(){
        try {
            txtCodigo.setText(rs.getString(1));
            txtNombre.setText(rs.getString(2));
            txtApellidos.setText(rs.getString(3));
            txtDireccion.setText(rs.getString(4));
            txtCodDis.setText(rs.getString(5));
            txtTelefono.setText(rs.getString(6));
            String sexo = rs.getString(7);
            if (sexo.compareTo("M")==0){
              cboSexo.setSelectedIndex(1);
            } else {
              cboSexo.setSelectedIndex(2);
            }
            //cboSexo.addItem(rs.getString(7));
            txtCorreo.setText(rs.getString(8));
            jdFecha.setText(rs.getString(9));
        } catch (Exception e){
            JOptionPane.showMessageDialog(null, e);
        }
        
    }
    public void MostrarDistrito(){
        try {
            String sql = "SELECT * FROM tbldistrito";
            conec = con.Conectar();
            st = conec.createStatement();
            rs = st.executeQuery(sql);
            cboDistrito.addItem("Seleccionar...");
            while (rs.next()){
                cboDistrito.addItem(rs.getString("Nom_Distrito"));
            }
            rs.close();
        } catch (Exception e){
            JOptionPane.showMessageDialog(null, e);
        }
    }
    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        dateChooserDialog1 = new datechooser.beans.DateChooserDialog();
        btnNuevo = new javax.swing.JButton();
        btnGuardar = new javax.swing.JButton();
        btnModificar = new javax.swing.JButton();
        btnCancelar = new javax.swing.JButton();
        btnSalir = new javax.swing.JButton();
        jPanel1 = new javax.swing.JPanel();
        jLabel6 = new javax.swing.JLabel();
        cboSexo = new javax.swing.JComboBox<>();
        jLabel7 = new javax.swing.JLabel();
        jLabel8 = new javax.swing.JLabel();
        txtTelefono = new javax.swing.JTextField();
        jLabel9 = new javax.swing.JLabel();
        txtCorreo = new javax.swing.JTextField();
        jLabel1 = new javax.swing.JLabel();
        txtCodigo = new javax.swing.JTextField();
        jLabel2 = new javax.swing.JLabel();
        txtNombre = new javax.swing.JTextField();
        jLabel3 = new javax.swing.JLabel();
        txtApellidos = new javax.swing.JTextField();
        jLabel4 = new javax.swing.JLabel();
        txtDireccion = new javax.swing.JTextField();
        jLabel5 = new javax.swing.JLabel();
        cboDistrito = new javax.swing.JComboBox<>();
        txtCodDis = new javax.swing.JTextField();
        jdFecha = new datechooser.beans.DateChooserCombo();
        jPanel2 = new javax.swing.JPanel();
        btnPrimero = new javax.swing.JButton();
        jPanel3 = new javax.swing.JPanel();
        btnUltimo = new javax.swing.JButton();
        btnSiguiente = new javax.swing.JButton();
        btnAnterior = new javax.swing.JButton();
        jLabel10 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        btnNuevo.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        btnNuevo.setText("NUEVO");
        btnNuevo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnNuevoActionPerformed(evt);
            }
        });
        getContentPane().add(btnNuevo, new org.netbeans.lib.awtextra.AbsoluteConstraints(607, 70, 100, -1));

        btnGuardar.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        btnGuardar.setText("GUARDAR");
        getContentPane().add(btnGuardar, new org.netbeans.lib.awtextra.AbsoluteConstraints(610, 140, 100, -1));

        btnModificar.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        btnModificar.setText("MODIFICAR");
        getContentPane().add(btnModificar, new org.netbeans.lib.awtextra.AbsoluteConstraints(610, 200, -1, -1));

        btnCancelar.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        btnCancelar.setText("CANCELAR");
        getContentPane().add(btnCancelar, new org.netbeans.lib.awtextra.AbsoluteConstraints(610, 270, 100, -1));

        btnSalir.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        btnSalir.setText("SALIR");
        btnSalir.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnSalirActionPerformed(evt);
            }
        });
        getContentPane().add(btnSalir, new org.netbeans.lib.awtextra.AbsoluteConstraints(610, 330, 100, -1));

        jPanel1.setBorder(javax.swing.BorderFactory.createTitledBorder("DATOS DEL CLIENTE"));
        jPanel1.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        jPanel1.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jLabel6.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        jLabel6.setText("FECHA DE NACIMIENTO:");
        jPanel1.add(jLabel6, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 170, -1, -1));

        cboSexo.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        cboSexo.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Seleccionar...", "M", "F" }));
        cboSexo.setEnabled(false);
        jPanel1.add(cboSexo, new org.netbeans.lib.awtextra.AbsoluteConstraints(420, 170, 120, -1));

        jLabel7.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        jLabel7.setText("SEXO:");
        jPanel1.add(jLabel7, new org.netbeans.lib.awtextra.AbsoluteConstraints(370, 170, -1, -1));

        jLabel8.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        jLabel8.setText("TELEFONO:");
        jPanel1.add(jLabel8, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 220, -1, -1));

        txtTelefono.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        txtTelefono.setEnabled(false);
        jPanel1.add(txtTelefono, new org.netbeans.lib.awtextra.AbsoluteConstraints(110, 220, 128, -1));

        jLabel9.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        jLabel9.setText("CORREO:");
        jPanel1.add(jLabel9, new org.netbeans.lib.awtextra.AbsoluteConstraints(260, 220, -1, -1));

        txtCorreo.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        txtCorreo.setEnabled(false);
        jPanel1.add(txtCorreo, new org.netbeans.lib.awtextra.AbsoluteConstraints(330, 220, 150, -1));

        jLabel1.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        jLabel1.setText("CODIGO:");
        jPanel1.add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 20, -1, -1));

        txtCodigo.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        txtCodigo.setEnabled(false);
        jPanel1.add(txtCodigo, new org.netbeans.lib.awtextra.AbsoluteConstraints(70, 20, 91, -1));

        jLabel2.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        jLabel2.setText("NOMBRE:");
        jPanel1.add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 60, -1, -1));

        txtNombre.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        txtNombre.setEnabled(false);
        jPanel1.add(txtNombre, new org.netbeans.lib.awtextra.AbsoluteConstraints(80, 60, 111, -1));

        jLabel3.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        jLabel3.setText("APELLIDOS:");
        jPanel1.add(jLabel3, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 60, -1, -1));

        txtApellidos.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        txtApellidos.setEnabled(false);
        jPanel1.add(txtApellidos, new org.netbeans.lib.awtextra.AbsoluteConstraints(300, 60, 132, -1));

        jLabel4.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        jLabel4.setText("DIRECCIÓN:");
        jPanel1.add(jLabel4, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 110, -1, -1));

        txtDireccion.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        txtDireccion.setEnabled(false);
        jPanel1.add(txtDireccion, new org.netbeans.lib.awtextra.AbsoluteConstraints(100, 110, 178, -1));

        jLabel5.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        jLabel5.setText("DISTRITO:");
        jPanel1.add(jLabel5, new org.netbeans.lib.awtextra.AbsoluteConstraints(290, 120, -1, -1));

        cboDistrito.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        cboDistrito.setEnabled(false);
        cboDistrito.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                cboDistritoActionPerformed(evt);
            }
        });
        jPanel1.add(cboDistrito, new org.netbeans.lib.awtextra.AbsoluteConstraints(360, 120, 180, -1));
        jPanel1.add(txtCodDis, new org.netbeans.lib.awtextra.AbsoluteConstraints(470, 80, 70, 30));

        jdFecha.setEnabled(false);
        jdFecha.setFieldFont(new java.awt.Font("Tahoma", java.awt.Font.PLAIN, 14));
        jPanel1.add(jdFecha, new org.netbeans.lib.awtextra.AbsoluteConstraints(180, 170, -1, -1));

        getContentPane().add(jPanel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 80, 560, 280));

        jPanel2.setBorder(javax.swing.BorderFactory.createTitledBorder("MANTENIMIENTO"));
        jPanel2.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        jPanel2.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());
        getContentPane().add(jPanel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(580, 40, 150, 350));

        btnPrimero.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        btnPrimero.setText("PRIMERO");
        btnPrimero.setEnabled(false);
        btnPrimero.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnPrimeroActionPerformed(evt);
            }
        });
        getContentPane().add(btnPrimero, new org.netbeans.lib.awtextra.AbsoluteConstraints(100, 390, -1, -1));

        jPanel3.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        btnUltimo.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        btnUltimo.setText("ULTIMO");
        btnUltimo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnUltimoActionPerformed(evt);
            }
        });
        jPanel3.add(btnUltimo, new org.netbeans.lib.awtextra.AbsoluteConstraints(350, 20, -1, -1));

        btnSiguiente.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        btnSiguiente.setText("SIGUIENTE");
        btnSiguiente.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnSiguienteActionPerformed(evt);
            }
        });
        jPanel3.add(btnSiguiente, new org.netbeans.lib.awtextra.AbsoluteConstraints(240, 20, -1, -1));

        btnAnterior.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        btnAnterior.setText("ANTERIOR");
        btnAnterior.setEnabled(false);
        btnAnterior.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAnteriorActionPerformed(evt);
            }
        });
        jPanel3.add(btnAnterior, new org.netbeans.lib.awtextra.AbsoluteConstraints(130, 20, -1, -1));

        getContentPane().add(jPanel3, new org.netbeans.lib.awtextra.AbsoluteConstraints(80, 370, 440, 60));

        jLabel10.setFont(new java.awt.Font("Tahoma", 0, 24)); // NOI18N
        jLabel10.setText("MANTENIMIENTO DE CLIENTES");
        getContentPane().add(jLabel10, new org.netbeans.lib.awtextra.AbsoluteConstraints(180, 10, -1, -1));

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnNuevoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnNuevoActionPerformed
        // TODO add your handling code here:
        //cboDistrito.setSelectedIndex(0);
        //cboSexo.setSelectedIndex(0);
        txtCodigo.setEnabled(true);
        txtNombre.setEnabled(true);
        txtApellidos.setEnabled(true);
        txtDireccion.setEnabled(true);
        txtTelefono.setEnabled(true);
        txtCorreo.setEnabled(true);
        cboDistrito.setEnabled(true);
        cboSexo.setEnabled(true);
        txtCodigo.setText("");
        txtNombre.setText("");
        txtApellidos.setText("");
        txtDireccion.setText("");
        txtTelefono.setText("");
        txtCorreo.setText("");
        cboSexo.addItem("Seleccionar...");
        cboSexo.addItem("M");
        cboSexo.addItem("F");
        //dateFecha.setEnabled(true);
        //txtCodigoDistrito.setText("");
    }//GEN-LAST:event_btnNuevoActionPerformed

    private void cboDistritoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_cboDistritoActionPerformed
        try {
            String sql = "select * from tbldistrito where Nom_Distrito = '"+cboDistrito.getSelectedItem()+"'";
            conec = con.Conectar();
            st = conec.createStatement();
            rs = st.executeQuery(sql);
            rs.next();
            txtCodDis.setText(rs.getString("Id_Distrito"));
        } catch (Exception e){
            JOptionPane.showMessageDialog(null, e);
        }
    }//GEN-LAST:event_cboDistritoActionPerformed

    private void btnSalirActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnSalirActionPerformed
        // TODO add your handling code here:
        dispose();
    }//GEN-LAST:event_btnSalirActionPerformed

    private void btnSiguienteActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnSiguienteActionPerformed
        // TODO add your handling code here:
        try {
                if (rs.isLast()==false){
                rs.next();
                Llenar();
                btnPrimero.setEnabled(true);
                btnAnterior.setEnabled(true);
            }
        } catch (Exception e){
            JOptionPane.showMessageDialog(null, e);
        }
    }//GEN-LAST:event_btnSiguienteActionPerformed

    private void btnUltimoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnUltimoActionPerformed
        // TODO add your handling code here:
        try {
            rs.last();
            Llenar();
            btnUltimo.setEnabled(false);
            btnSiguiente.setEnabled(false);
            btnPrimero.setEnabled(true);
            btnAnterior.setEnabled(true);
        } catch (Exception e){
            JOptionPane.showMessageDialog(null, e);
        }
    }//GEN-LAST:event_btnUltimoActionPerformed

    private void btnPrimeroActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnPrimeroActionPerformed
        // TODO add your handling code here:
        try {
            rs.first();
            Llenar();
            btnPrimero.setEnabled(false);
            btnAnterior.setEnabled(false);
            btnSiguiente.setEnabled(true);
            btnUltimo.setEnabled(true);
        } catch (Exception e){
            JOptionPane.showMessageDialog(null, e);
        }
    }//GEN-LAST:event_btnPrimeroActionPerformed

    private void btnAnteriorActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAnteriorActionPerformed
        // TODO add your handling code here:
        try {
            if (rs.isFirst()==false){
                rs.previous();
                Llenar();
              
            }
            btnSiguiente.setEnabled(true);
            btnUltimo.setEnabled(true);
        } catch (Exception e){
            JOptionPane.showMessageDialog(null, e);
        }
    }//GEN-LAST:event_btnAnteriorActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(RegistroClientes.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(RegistroClientes.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(RegistroClientes.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(RegistroClientes.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new RegistroClientes().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnAnterior;
    private javax.swing.JButton btnCancelar;
    private javax.swing.JButton btnGuardar;
    private javax.swing.JButton btnModificar;
    private javax.swing.JButton btnNuevo;
    private javax.swing.JButton btnPrimero;
    private javax.swing.JButton btnSalir;
    private javax.swing.JButton btnSiguiente;
    private javax.swing.JButton btnUltimo;
    private javax.swing.JComboBox<String> cboDistrito;
    private javax.swing.JComboBox<String> cboSexo;
    private datechooser.beans.DateChooserDialog dateChooserDialog1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel10;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel3;
    private datechooser.beans.DateChooserCombo jdFecha;
    private javax.swing.JTextField txtApellidos;
    private javax.swing.JTextField txtCodDis;
    private javax.swing.JTextField txtCodigo;
    private javax.swing.JTextField txtCorreo;
    private javax.swing.JTextField txtDireccion;
    private javax.swing.JTextField txtNombre;
    private javax.swing.JTextField txtTelefono;
    // End of variables declaration//GEN-END:variables
}
