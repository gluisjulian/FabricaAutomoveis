namespace Automovel.Domain
{
    public class Automoveis : DTIDomain.Core.DomainBase
    {   
        public int idAutomovel { get; set; }
        public string modeloAutomovel { get; set; }

        public int anoAutomovel { get; set; }

        public override void Validar()
        {
            _regrasQuebradas.Clear();
            if (string.IsNullOrEmpty(modeloAutomovel))
                _regrasQuebradas.Add("Nome do Animal não pode ser vazio");

            if (anoAutomovel <= 0)
                _regrasQuebradas.Add("O Código deve ser maior que 0");
        }
    }
}

