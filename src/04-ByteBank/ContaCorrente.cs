﻿


public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    public bool Saque(double valor)
    {
        if(this.saldo < valor)
        {
            return false;
        }
        
        this.saldo -= valor;
        return true;
    }
}


