function sprawdzian() {
    let prawo = document.getElementById("prawo");
    let cyfra = document.getElementById("cyfra").value;
    let tekst = document.getElementById("tekst");
    let ZczyP = document.getElementById("ZczyP");
    let literka = document.getElementById("Literka");
    let tabela = document.getElementById("Tablica");
    if (ZczyP.checked) {
        let dzielniki = 0;
        for(let i = 1; i<=cyfra;i++)
        {
            if(cyfra%i==0)
            {
                dzielniki++;
            }
        }
        if(dzielniki==2)
        {
            prawo.innerHTML = "<font>Pierwsza</font>"
        }
        else{
            prawo.innerHTML = "<font>Zlozona</font>"
        }
    }
    if (literka.checked) {
        let indexLiterki = parseInt(cyfra, 10);
        let tekstValue = tekst.value;

        if (indexLiterki >= 0 && indexLiterki < tekstValue.length) {
            let literka = tekstValue[indexLiterki];
            prawo.innerHTML = `<font>${literka}</font>`;
        } else {
            prawo.innerHTML = "<font>Indeks poza zakresem</font>";
        }
    }

}
