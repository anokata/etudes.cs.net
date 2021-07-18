using System;

public struct ComplexNumber
{
    private double real;
    private double img;

    public ComplexNumber(double real, double imaginary)
    {
        this.real = real;
        this.img = imaginary;
    }

    public double Real() => real;

    public double Imaginary() => img;

    public ComplexNumber Mul(ComplexNumber other)
    {
        double c = other.Real();
        double d = other.Imaginary();
        return new ComplexNumber((real*c - img*d), (img*c + real*d));
    }

    public ComplexNumber Add(ComplexNumber other)
        => new ComplexNumber(real + other.Real(), img + other.Imaginary());

    public ComplexNumber Sub(ComplexNumber other)
        => new ComplexNumber(real - other.Real(), img - other.Imaginary());

    public ComplexNumber Div(ComplexNumber other)
    {
        double a = real;
        double b = img;
        double c = other.Real();
        double d = other.Imaginary();
        return new ComplexNumber((a*c + b*d)/(c*c + d*d), (b*c-a*d)/(c*c + d*d));
    }

    public double Abs()
        => Math.Sqrt(real*real + img*img);

    public ComplexNumber Conjugate()
        => new ComplexNumber(real, -img);
    
    public ComplexNumber Exp()
        => new ComplexNumber(Math.Exp(real) * Math.Cos(img), Math.Exp(real) * Math.Sin(img));
}