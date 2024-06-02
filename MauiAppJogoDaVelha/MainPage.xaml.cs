namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "x";
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.IsEnabled = false;
            if (vez == "x")
            {
                btn.Text = "x";
                vez = "O";
            }
            else
            {
                btn.Text = "O";
                vez = "x";
            }

            //verificando s eo x ganhou
            if (btn10.Text == "x" && btn11.Text == "x" && btn12.Text == "x")
            {
                DisplayAlert("Prabens", "o X ganhou", "ok");
                zerar();
            }

            if (btn20.Text == "x" && btn21.Text == "x" && btn22.Text == "x")
            {
                DisplayAlert("Prabens", "o X ganhou", "ok");
                zerar();
            }

            if (btn30.Text == "x" && btn31.Text == "x" && btn32.Text == "x")
            {
                DisplayAlert("Prabens", "o X ganhou", "ok");
                zerar();
            }

            if (btn10.Text == "x" && btn20.Text == "x" && btn30.Text == "x")
            {
                DisplayAlert("Prabens", "o X ganhou", "ok");
                zerar();
            }

            if (btn11.Text == "x" && btn21.Text == "x" && btn31.Text == "x")
            {
                DisplayAlert("Prabens", "o X ganhou", "ok");
                zerar();
            }

            if (btn12.Text == "x" && btn22.Text == "x" && btn32.Text == "x")
            {
                DisplayAlert("Prabens", "o X ganhou", "ok");
                zerar();
            }

            if (btn10.Text == "x" && btn21.Text == "x" && btn32.Text == "x")
            {
                DisplayAlert("Prabens", "o X ganhou", "ok");
                zerar();
            }

            if (btn12.Text == "x" && btn21.Text == "x" && btn30.Text == "x")
            {
                DisplayAlert("Prabens", "o X ganhou", "ok");
                zerar();
            }

            //verificando se o O ganhou
            if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                DisplayAlert("Prabens", "o O ganhou", "ok");
                zerar();
            }

            if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                DisplayAlert("Prabens", "o O ganhou", "ok");
                zerar();
            }

            if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Prabens", "o O ganhou", "ok");
                zerar();
            }

            if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("Prabens", "o O ganhou", "ok");
                zerar();
            }

            if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
            {
                DisplayAlert("Prabens", "o O ganhou", "ok");
                zerar();
            }

            if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Prabens", "o O ganhou", "ok");
                zerar();
            }

            if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Prabens", "o O ganhou", "ok");
                zerar();
            }

            if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("Prabens", "o O ganhou", "ok");
                zerar();
            }

            else if(
                btn10.Text != "" &&
                btn11.Text != "" &&
                btn12.Text != "" &&
                btn20.Text != "" &&
                btn21.Text != "" &&
                btn22.Text != "" &&
                btn30.Text != "" &&
                btn31.Text != "" &&
                btn32.Text != ""
                )
            {
                DisplayAlert("ops", "o jogo deu velha", "limpar");
                zerar();
            }

            void zerar()
            {
                btn10.Text = "";
                btn11.Text = "";
                btn12.Text = "";
                btn20.Text = "";
                btn21.Text = "";
                btn22.Text = "";
                btn30.Text = "";
                btn31.Text = "";
                btn32.Text = "";

                btn10.IsEnabled = true;
                btn11.IsEnabled = true;
                btn12.IsEnabled = true;
                btn20.IsEnabled = true;
                btn21.IsEnabled = true;
                btn22.IsEnabled = true;
                btn30.IsEnabled = true;
                btn31.IsEnabled = true;
                btn32.IsEnabled = true;
            }
        }

    }
}
