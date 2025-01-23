using System.Text;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection.PortableExecutable;

namespace Bingo
{
    /// <summary>
    /// Interaction logic for Jugador.xaml
    /// </summary>
    public partial class Jugador : Window
    {
        private string[] Pequeñas_Oraciones = { "El perro ladro fuerte",
                                                "La caja se rompio",
                                                "Ayer se comio pizza",
                                                "Mira el mar desde la playa",
                                                "Llovio en la ciudad",
                                                "Esa flor es muy linda",
                                                "El gato duerme en casa",
                                                "Corre lento hacia el parque",
                                                "La flor crece en el jardin",
                                                "Ve al cine con amigos"};
        private char[] frase;
        private int[] ASCII = new int[26];
        private List<TextBox> textBoxes = new List<TextBox>();
        private List<Label> labels = new List<Label>();
        private double txtboxleft = 60;
        private double txtboxtop = 123;
        public Jugador()
        {
            InitializeComponent();
            Metodos.SFXIntro();
            Almacenarnumeros();
            GenerarTextBox();
        }
        private void Almacenarnumeros()
        {
            for (int i = 0; i < 26; i++)
            {
                ASCII[i] = 65 + i;
            }
        }
        private void GenerarTextBox()
        {
            Random random = new Random();
            frase = Pequeñas_Oraciones[random.Next(0, 9)].ToUpper().ToCharArray();
            for (int i = 0; i < frase.Length; i++)
            {
                int decision = random.Next(0, 101);
                if (decision <= 10)
                {
                    if (frase[i] != ' ')
                    {
                        Label label = new Label
                        {
                            Name = $"label{i}",
                            Width = 80,
                            Height = 80,
                            FontSize = 50,
                            Content = $"{ASCII[frase[i] - 'A']}",
                            HorizontalAlignment = HorizontalAlignment.Center,
                            VerticalAlignment = VerticalAlignment.Center
                        };
                        Canvas.SetLeft(label, txtboxleft + 5);
                        Canvas.SetTop(label, txtboxtop - 80);
                        canvas.Children.Add(label);
                        labels.Add(label);

                        TextBox textbox = new TextBox
                        {
                            Name = $"Casillero{i}",
                            Width = 80,
                            Height = 80,
                            TextAlignment = TextAlignment.Center,
                            FontSize = 60,
                            Text = $"{frase[i]}",
                            IsReadOnly = true,
                            Background = Brushes.White,
                            BorderBrush = Brushes.Transparent
                        };
                        textbox.TextChanged += Casillero_TextChanged;
                        Canvas.SetLeft(textbox, txtboxleft);
                        Canvas.SetTop(textbox, txtboxtop);
                        canvas.Children.Add(textbox);
                        textBoxes.Add(textbox);
                        txtboxleft += 100;
                    }
                    else
                    {
                        if (txtboxleft >= 400)
                        {
                            txtboxtop += 180;
                            txtboxleft = 60;
                        }
                        else
                            txtboxleft += 120;
                    }
                }
                else if (decision > 10)
                {
                    if (frase[i] != ' ')
                    {
                        Label label = new Label
                        {
                            Name = $"label{i}",
                            Width = 80,
                            Height = 80,
                            FontSize = 50,
                            Content = $"{ASCII[frase[i] - 'A']}",
                            HorizontalAlignment = HorizontalAlignment.Center,
                            VerticalAlignment = VerticalAlignment.Center
                        };
                        Canvas.SetLeft(label, txtboxleft + 5);
                        Canvas.SetTop(label, txtboxtop - 80);
                        canvas.Children.Add(label);
                        labels.Add(label);

                        TextBox textbox = new TextBox
                        {
                            Name = $"Casillero{i}",
                            Width = 80,
                            Height = 80,
                            TextAlignment = TextAlignment.Center,
                            FontSize = 60,
                            IsReadOnly = false,
                            Text = $"",
                            Background = Brushes.LightBlue,
                            BorderBrush = Brushes.Transparent
                        };
                        textbox.TextChanged += Casillero_TextChanged;
                        Canvas.SetLeft(textbox, txtboxleft);
                        Canvas.SetTop(textbox, txtboxtop);
                        canvas.Children.Add(textbox);
                        textBoxes.Add(textbox);
                        txtboxleft += 100;
                    }
                    else
                    {
                        if (txtboxleft >= 400)
                        {
                            txtboxtop += 180;
                            txtboxleft = 60;
                        }
                        else
                            txtboxleft += 120;
                    }
                }
            }
            
        }

        private void Casillero_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox casillero)
            {
                for (int i = 1; i < 10; i++)
                {
                    if (casillero.Text == $"{i}")
                    {
                        MessageBox.Show("Tienes que agregar letras mas no números", "No hagas eso");
                        casillero.Text = "";
                    }
                }
                if (casillero.Text.Length > 1)
                {
                    casillero.Text = casillero.Text.Substring(0, 1);
                    casillero.SelectionStart = casillero.Text.Length;
                    MessageBox.Show("No puedes agregar más letras", "Error");
                }
            }
        }

        private int contador = 0; 
        private async void Click_Verificar(object sender, RoutedEventArgs e)
        {
            contador++;
            for (int i = 0; i < textBoxes.Count; i++)
            {
                TextBox textBox = textBoxes[i];
                Label label = labels[i];
                if (textBox.IsReadOnly == false && !string.IsNullOrEmpty(textBox.Text))
                {
                    char charFromTextBox = Convert.ToChar(textBox.Text);
                    int unicodeValueFromTextBox = Convert.ToInt32(charFromTextBox);
                    int expectedUnicodeValue = Convert.ToInt32(label.Content);
                    if (unicodeValueFromTextBox == expectedUnicodeValue)
                    {
                        Metodos.SfxCorrect();
                        textBox.Background = Brushes.Green;
                        await Task.Delay(300);
                        textBox.IsReadOnly = true;
                    }
                    else
                    {
                        Metodos.SfxError();
                        textBox.Background = Brushes.Red;
                        await Task.Delay(800);
                        break;
                    }
                }
                else if (string.IsNullOrEmpty(textBox.Text))
                {
                    Metodos.SfxRemove();
                    MessageBox.Show("No has escrito nada aún...");
                    break;
                }
                if (i == textBoxes.Count - 1 && textBoxes[i].IsReadOnly == true)
                {
                    MessageBox.Show($"Completaste la ventana extra\nNumero de intentos: {contador}", "Felicidades");
                    Storyboard desaparecer = (Storyboard)FindResource("DesaparecerCanvas"); desaparecer.Begin(canvas);
                    await Task.Delay(2000);
                    this.Close();
                }
            }   
        }
        private void BtnVerificar_Entrar(object sender, MouseEventArgs e) => Metodos.SfxBtn();
    }
}