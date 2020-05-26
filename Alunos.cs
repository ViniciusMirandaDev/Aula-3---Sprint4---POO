namespace CadastroAlunos
{
    public class Aluno
    {
        public string nome;
        public string curso;
        public int idade;
        public string rg;
        public bool bolsista;
        public float percentual;
        public float mediaFinal;
        public float valorMensalidade;

        public float VerMediaFinal(){
            return mediaFinal;
        }

        public float VerMensalidade(){

            float calculo = valorMensalidade;

            if(bolsista == true){
                calculo = valorMensalidade - (valorMensalidade * percentual / 100);
            }

            return calculo;
        }
    }
}