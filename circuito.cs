namespace Trabalho2
{
    public class circuito
    {
        Circuito::Circuito(float r1, float r2, float f) {
            resistencia1 = r1;
            resistencia2 = r2;
            fonte = f;
        }

        Circuito::Circuito(float r1, float r2) {
            resistencia1 = r1;
            resistencia2 = r2;
        }

        void Circuito::setR1(float r1) {
            resistencia1 = r1;
        }

        float Circuito::getR1() {
            return resistencia1;
        }

        void Circuito::setR2(float r2) {
            resistencia2 = r2;
        }

        float Circuito::getR2() {
            return resistencia2;
        }

        void Circuito::setF1(float f) {
            fonte = f;
        }

        float Circuito::getF1() {
            return fonte;
        }

        float Circuito::resistenciaSerie() {
            return (resistencia1 + resistencia2);
        }

        float Circuito::resistenciaParalelo() {
            return ((resistencia1 * resistencia2) / (resistencia1 + resistencia2));
        }

        float Circuito::correnteTotalSerie() {
            float corrente = fonte / resistenciaSerie();
            return corrente;
        }

        float Circuito::correnteTotalParalelo() {
            float corrente = fonte / resistenciaParalelo();
            return corrente;
        }

        float Circuito::potenciaFonteSerie() {
            float potencia = fonte * correnteTotalSerie();
            return potencia;
        }

        float Circuito::potenciaFonteParalelo() {
            float potencia = fonte * correnteTotalParalelo();
            return potencia;
        }

        Circuito Circuito::potObjSerie(Circuito c1, Circuito c2) {
            if (c1.potenciaFonteSerie() < c2.potenciaFonteSerie()) {
                return c1;
            }
            return c2;
        }

        Circuito Circuito::potObjParalelo(Circuito c1, Circuito c2) {
            if (c1.potenciaFonteParalelo() < c2.potenciaFonteParalelo()) {
                return c1;
            }
            return c2;
        }
    }
}