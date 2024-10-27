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
            try
            {
                Node newNode = new Node(Convert.ToInt32(txtData.Text));
                miPila.Push(newNode);
                UpdateStack();
                txtData.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido.");
            }
        }

        private void btnPop_Click(object sender, EventArgs e)
        {

            if (!miPila.IsEmpty())
            {
                Node poppedNode = miPila.Pop();
                UpdateStack();
                MessageBox.Show("Elemento eliminado: " + poppedNode.Data);
                return;
            }
            UpdateStack();
            MessageBox.Show("La pila está vacía.");
            return;

        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            Node topNode = miPila.Peek();
            if (!miPila.IsEmpty())
            {
                MessageBox.Show("Elemento en el top: " + topNode.Data);
                return;
            }
            MessageBox.Show("La pila está vacía.");
            return;
        }



        private void UpdateStack()
        {
            lstPila.Items.Clear(); // Limpia la lista antes de actualizar
            Node currentNode = miPila.Peek(); // Asegúrate de que esto esté correctamente referenciado

            while (currentNode != null)
            {
                lstPila.Items.Add(currentNode.Data);
                currentNode = currentNode.Next;
            }
        }

        private void BtnSize_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hay " + miPila.Size() + " elementos en la pila");
        }
    }

}
