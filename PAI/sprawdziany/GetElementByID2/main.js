function CzyPierwsza(n)
{
    let wynik = document.getElementById("wynik-1");
    let dzielniki = 0;
    for(let i = 1; i<=n;i++)
    {
        if(n%i==0)
        {
            dzielniki++;
        }
    }
    if (dzielniki == 2)
    {
        wynik.innerHTML = `<font>Pierwsza elo</font>`
    }
    else{
        wynik.innerHTML = `<font>Zlozona bec</font>`
    }
}
function Litera(n)
{
    let ciag = document.getElementById("zdanie");
    let wynik = document.getElementById("wynik-2");
    let wyjscie = ciag[n];
    wynik.innerHTML = `<font>${wyjscie}</font>`
}
function GenerujTabele(n)
{
    let wynik = document.getElementById("wynik-3");
    let output = `<table>`
    output+= `<tr>`
    for(let i = 0;i<n;i++)
    {
        output += `<td>${i}</td>`
    }
    output += `</tr>`
    output += `</table>`
    wynik.innerHTML = output;
}
function wykonywanie()
{
    let cyferka = document.getElementById("numer").value;
    let check_pierwsza = document.getElementById("ZczyP");
    let check_literka = document.getElementById("LiterkaZZdania");
    let check_tabelka = document.getElementById("tabeleczka");
    if(check_pierwsza.checked)
    {
        CzyPierwsza(cyferka);
    }
    if(check_literka.checked)
    {
        Litera(cyferka);
    }
    if(check_tabelka.checked)
    {
        GenerujTabele(cyferka);
    }
}