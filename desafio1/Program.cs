
using System.Globalization;
using System.Text;

string inverteBits(string strBin){
    string str=strBin.Substring(6,1);
    string aux = strBin.Substring(7,1);
    
    if(str == "0"){
        str = "1";
    }else{
        str = "0";
    }
    if(aux == "0"){
        aux = "1";
    }else{
        aux = "0";
    }
    str += aux;
    aux = strBin.Substring(4,2);
    aux +=str;
    str = strBin.Substring(0,4);
    aux += str;
   // aux = strBin.Substring(4,2)+ str + aux + strBin.Substring (0,4) ;
    return aux;
}

string msgCriptografada = "10010110 11110111 01010110 00000001 00010111 00100110 01010111 00000001 00010111 01110110 01010111 00110110 11110111 11010111 01010111 00000011";
string resposta = "";
string []alfabeto = {" ","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
string[]aux = new string[16];
int cont = 0;
for (int i = 0; i < msgCriptografada.Length; i+=9)
{
    aux[cont] = msgCriptografada.Substring(i,8);
    cont++;   
}
for (int i = 0; i < aux.Length; i++)
{
   aux[i] = inverteBits(aux[i]);
}
for (int i = 0; i < aux.Length; i++)
{
    resposta += aux[i]+ " ";
}

for (int i = 0; i < resposta.Length; i=i+9)
{
    int a = Int32.Parse(resposta.Substring(3+i,1));
    int b = Int32.Parse(resposta.Substring(4+i,1));
    int c = Int32.Parse(resposta.Substring(5+i,1));
    int d = Int32.Parse(resposta.Substring(6+i,1));
    int e = Int32.Parse(resposta.Substring(7+i,1));
    int f = a*16 + b*8 + c*4 +d*2+ e*1;
    Console.Write(alfabeto[f]);
}



