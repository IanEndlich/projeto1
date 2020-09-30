namespace CalculoFreteEvino
 {
 public partial class Form1 : Form
 {
 public Form1()
 {
 InitializeComponent();
 }

 public void CalcularFrete()
 {
 //Declaro as variáveis para o nome, valor e estado
 string nome = txtNome.Text;
 decimal valor = decimal.Parse(txtValor.Text);
 string estado = cboEstado.SelectedItem.ToString();

 //Declaro e inicializo as variáveis frete e total
 decimal frete = 0, total = 0;

 //teste condicional para calcular o valor do frete
 if (valor > 1000)
 {
 frete = 0;
 }

 else
 {
 switch (estado)
 {
 case "SP": frete = 5;
 break;

 case "RJ": frete = 10;
 break;

 case "AM": frete = 20;
 break;

 default: frete = 15;
 break;
 }
 }

 //Armazeno na variável total o valor digitado mais o frete
 total = valor + frete;

 //Armazeno os valores nos respectivos labels
 lblValorCompra.Text = valor.ToString("C");
 lblValorFrete.Text = frete.ToString("C");
 lblValorTotal.Text = total.ToString("C");
 }

 public void LimparCampos()
 {
 //Finalizando, método para limpar as variáveis
 txtNome.Text = string.Empty;
 txtValor.Text = string.Empty;
 cboEstado.SelectedValue = string.Empty;
 lblValorCompra.Text = string.Empty;
 lblValorFrete.Text = string.Empty;
 lblValorTotal.Text = string.Empty;
 }

 private void btnCalcular_Click(object sender, EventArgs e)
 {
 CalcularFrete();
 }

 private void btnLimpar_Click(object sender, EventArgs e)
 {
 LimparCampos();
 }
 }
 }