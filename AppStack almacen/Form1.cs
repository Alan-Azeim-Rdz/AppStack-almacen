namespace AppStack_almacen
{
    public partial class Form1 : Form
    {
        Stack miPila = new Stack();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            int dato;
            if (int.TryParse(txtDato.Text, out dato))
            {
                miPila.Push(dato);
                ActualizarPila();
                txtDato.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido.");
            }
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            string resultado = miPila.Pop();
            MessageBox.Show(resultado);
            ActualizarPila();
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            string resultado = miPila.Peek();
            MessageBox.Show("Elemento en el tope: " + resultado);
        }



        private void ActualizarPila()
        {
            lstPila.Items.Clear();
            Stack temporal = new Stack();
            string elemento;

            // Mostrar los elementos en la pila
            while (!miPila.IsEmpty())
            {
                elemento = miPila.Pop();
                lstPila.Items.Add(elemento);
                temporal.Push(int.Parse(elemento));
            }

            // Restaurar los elementos en la pila original
            while (!temporal.IsEmpty())
            {
                miPila.Push(int.Parse(temporal.Pop()));
            }
        }

        private void BtnSize_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hay " + miPila.Size() + " elementos en la pila");
        }
    }

}
