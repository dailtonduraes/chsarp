using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExemploEncapsulamento {
    class Cliente {
        private string _nome;
        private string _email;
        private int _idade;
        public  double Salario { get; private set; }

        public Cliente() {

        }
        public Cliente(string _nome, string _email) {
            this._nome = _nome;
            this._email = _email;
        }

        /*
        public string GetNome() {
            return _nome;
        }
        public string GetEmail() {
            return _email;
        }

        public double GetSalario() {
            return _salario;
        }

        public void setNome(string nome) {
            if (nome != null && nome.Length > 1) {
                _nome = nome;
            }
        }

        public void SetSalario(double salario) {
            _salario = salario;
        }*/

        //properties
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }
        public string Email {
            get { return _email; }
            set {
                if (value != null && value.Length > 1) {
                    _email = value;
                }
            }
        }
           
        public override string ToString() {
            return "O Funcionário " +
                    _nome +
                   " Email: " + _email +
                   " Recebe $" +
                   _salario.ToString("F2", CultureInfo.InvariantCulture) +
                   " de salário";
        }
    }
}
