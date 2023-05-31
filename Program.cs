//variable
double total = 0;
string n_barang;
double harga = 0;
double diskon =0;
double ppn = 0;

Main:
Console.WriteLine("========================================");
Console.WriteLine("|Kode Barang | Nama Barang  | Harga      |");
Console.WriteLine("| B001       | Xiomi MI A 1 | 2.500.000  |");
Console.WriteLine("| B002       | Lenovo A100  | 1.800.000  |");
Console.WriteLine("| B003       | Samsung J1   | 1.800.000  |");
Console.WriteLine("| B004       | Samsung S5   | 3.000.000  |");
Console.WriteLine("| B005       | Samsung S8   | 5.000.000  |");
Console.WriteLine("========================================");


//input 1
 Console.WriteLine("Masukan Kode Barang : ");
        string kode = Console.ReadLine();
        switch(kode){
            case "B001":
            n_barang = "Xiaomi MI A 1";
            harga = 2500000;
            break;

            case"B002":
            n_barang = "Lenovo A1000";
            harga = 1800000;;
            break;

            case "B003":
            n_barang = "Samsung J1";
            harga = 1800000;;
            break;

            case"B004":
            n_barang = "Samsung S5";
            harga =3000000;
            break;

            case "B005":
            n_barang = "Samsung S8";
            harga = 5000000;
            break;
            
            default: 
            Console.Clear();
            Console.WriteLine("Barang Tidak Ditemukan ");
            goto Main; //Go Back To Main Menu
        }
        total = total + harga;
        Console.WriteLine (n_barang + " telah ditambahkan Ke Keranjang");
        Console.WriteLine("Ketik Y untuk menambhakan Barang Ke Keranjang ? ");

        String jawaban = Console.ReadLine();
        if(jawaban == "Y" || jawaban == "y"){
            Console.Clear();
            goto Main;
        }

        else{

            //OUTPUT HERE
            Console.WriteLine("\n===========Struk Belanja Joko Phone==========");
        if( total > 5000000 && total <=10000000){
            Console.WriteLine("Selamat! Anda Mendapatkan Diskon 5% ^^^");
            Console.WriteLine("Harga Kotor : " + total);
            diskon = total * 0.05;
            total = total - diskon;
            ppn = total * 0.1;
            total = total + ppn;
            Console.WriteLine("Diskon Yang Didapatkan : " + diskon);
             string fix = total.ToString("#,##0.00"); //convert to currency
            Console.WriteLine("Besar PPN : "+ppn);
            Console.WriteLine("Total Bersih Setelah Diskon dan PPN 10% : IDR" + fix);
            Console.ReadKey();
        }
       else if( total > 10000000){
            Console.WriteLine("Selamat! Anda Mendapatkan Diskon 25% ^^^");
            Console.WriteLine("Harga Kotor : " + total);
            diskon = total * 0.25;
            total = total - diskon;
            ppn = total * 0.1;
            total = total + ppn;
             Console.WriteLine("Diskon Yang Didapatkan : " + diskon);
             Console.WriteLine("Besar PPN : "+ppn);
             string fix = total.ToString("#,##0.00"); //convert to currency
            Console.WriteLine("Total Bersih Setelah Diskon dan PPN 10% : IDR" + fix);
            Console.ReadKey();
        }
        else{
            Console.WriteLine("Harga Kotor : "+ total);
            ppn = total * 0.1;
            total = total + ppn;
            Console.WriteLine("Besar PPN : "+ppn);
             string fix = total.ToString("#,##0.00"); //convert to currency
            Console.WriteLine("Total Yang Harus Dibayar Setelah Terkena PPN 10% : IDR" + fix);
            Console.ReadKey();
        }
        }        
       