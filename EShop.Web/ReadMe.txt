Blank proje içine 
Eshop.web mvc core 2.2 identity


ApplicationCore ve Infrastructure class library  sağ tık property 2.2 sürümü
Webin dependendies add reference 2 class libraryı ekle
Infrastructure a applicationCore referans verdik yukarıdaki gibi..

----push-----

Klasörler oluşturuldu...

applicationcore-> entities->applicationuser.cs oluşturuldu miras alındığı için 
appplicationCore a 
install-package microsoft.aspnetcore.identity.entityframeworkcore -version 2.2.0 kuruldu

infrastructure -> Datası içine applicationdbcontext classı oluşturuldu ve 
install-package microsoft.entityframeworkcore.sqlserver -version 2.2.0

Webin içindeki data klasörü silindi.Zaten onun aynısını insfrastructure taşıdık yukarıda

add-migration Identity ve update-database insfrastructureda çalıştırdık

loginPartialdaki üstte identityuser ı appplicationuser la değiştir. viewimporta usingi ekle..
whatsappta detayı var

push categoryentityden önce add migration infrastructure a problem yaşarsan clean solution