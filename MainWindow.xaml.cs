using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModelsofComputationandSynthesis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SystemDesignMethodologies_Click(object sender, RoutedEventArgs e)
        {
            SystemDesignSynthesis SystemDesignSynthesisObject = new SystemDesignSynthesis();
            SystemDesignSynthesisObject.Show();
        }

        private void Modeling_Click(object sender, RoutedEventArgs e)
        {
            Modeling ModelingObject = new Modeling();
            ModelingObject.Show();
        }

        private void System_Synthesis_Click(object sender, RoutedEventArgs e)
        {
            SystemDesignSynthesis SystemDesignSynthesisObject = new SystemDesignSynthesis();
            SystemDesignSynthesisObject.Show();
        }

        private void HardwareSynthesis_Click(object sender, RoutedEventArgs e)
        {
            HardwareSynthesis HardwareSynthesisObject = new HardwareSynthesis();
            HardwareSynthesisObject.Show();
        }

        private void Verification_Click(object sender, RoutedEventArgs e)
        {
            Verification VerificationObject = new Verification();
            VerificationObject.Show();
        }

        private void Software_Synthesis_Click(object sender, RoutedEventArgs e)
        {
            SoftwareSynthesis SoftwareSynthesisObject = new SoftwareSynthesis();
            SoftwareSynthesisObject.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Certificate CertificateObject = new Certificate();
            CertificateObject.Show();
        }
    }
}
