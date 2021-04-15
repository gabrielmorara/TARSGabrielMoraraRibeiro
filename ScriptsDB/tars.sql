-- 1. Cria usuário para uso único da aplicação
create user tars
    superuser
    createdb
    createrole;

ALTER USER tars WITH PASSWORD 'tars';

-- 2. Cria Database tars
create database tars
    with owner tars;

-- 3. Cria tabelas
create table if not exists tars.public."Users"
(
    "UserID"        bigserial not null
        constraint users_pk
            primary key,
    "Name"          text      not null,
    "Cpf"           text      not null,
    "Email"         text      not null,
    "Created_at"    timestamp,
    "Updated_at"    timestamp,
    "Deleted_at"    time,
    "Password_hash" text      not null
);

alter table tars.public."Users"
    owner to tars;

create unique index if not exists users_cpf_uindex
    on tars.public."Users" ("Cpf");

create unique index if not exists users_userid_uindex
    on tars.public."Users" ("UserID");

create table if not exists tars.public."Categorys"
(
    "CategoryID" bigserial not null
        constraint category_pk
            primary key,
    "Name"       text      not null,
    "Created_at" timestamp,
    "Updated_at" timestamp,
    "Deleted_at" timestamp,
    "UserID"     bigserial not null
        constraint category_users_userid_fk
            references tars.public."Users"
);

alter table tars.public."Categorys"
    owner to tars;

create unique index if not exists category_categoryid_uindex
    on tars.public."Categorys" ("CategoryID");

create unique index if not exists categorys_name_uindex
    on tars.public."Categorys" ("Name");

create table if not exists tars.public."Products"
(
    "ProductID"    bigserial not null
        constraint products_pk
            primary key,
    "Title"        text      not null,
    "Brand"        text      not null,
    "Description"  text      not null,
    "Stock"        integer   not null,
    "PriceDefault" numeric   not null,
    "PriceOffer"   numeric   not null,
    ean            text      not null,
    ncm            text,
    "Warranty"     integer,
    "Height"       numeric   not null,
    "Lenght"       numeric   not null,
    "Width"        numeric   not null,
    "Weight"       numeric   not null,
    "UserID"       bigserial not null
        constraint products_users_userid_fk
            references tars.public."Users",
    "CategoryID"   bigserial not null
        constraint products_categorys_categoryid_fk
            references tars.public."Categorys",
    "Created_at"   timestamp,
    "Updated_at"   timestamp,
    "Deleted_at"   timestamp
);

alter table tars.public."Products"
    owner to tars;

create unique index if not exists products_productid_uindex
    on tars.public."Products" ("ProductID");

create unique index if not exists products_title_uindex
    on tars.public."Products" ("Title");

-- 4. Popula banco
INSERT INTO tars.public."Users" ("UserID", "Name", "Cpf", "Email", "Created_at", "Updated_at", "Deleted_at",
                                 "Password_hash")
VALUES (6, 'Gabriel Morara Ribeiro', '01009258982', 'gabriel.morara@gmail.com', '2021-04-12 13:38:55.031182',
        '2021-04-15 10:54:46.167664', null, '9nbrH75PGmRhvC9H9IX+nQ==');

INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (10, 'ELETRONICOS', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (11, 'TELEFONIA', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (12, 'ELETRODOMESTICOS', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (13, 'ARTES', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (14, 'AUTOMOTIVO', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (15, 'CAMA MESA E BANHO', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (16, 'BELEZA E SAUDE', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (17, 'AUDIO', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (18, 'CASA E CONFORTO', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (19, 'CONSOLES E GAMES', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (20, 'ELETROPORTATEIS', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (21, 'PC GAMER', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (22, 'PCS', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (23, '"TABLETS', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (24, 'INFORMATICA ACESSORIOS', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (26, 'TELEFONIA FIXA', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (27, 'CLIMATIZAÇÃO', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (28, 'ARTES E ARTESANATO', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (29, 'GENERICOS', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (30, 'INSTRUMENTOS MUSICAIS', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (31, 'CINE E FOTO', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (32, 'BRINQUEDOS', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (33, 'UTILIDADES DOMESTICAS', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (34, 'MÓVEIS - COLCHÃO E ESTOFADO', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (35, '"MÓVEIS - COZINHA', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (36, 'MÓVEIS - DECORAÇÃO', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (37, 'MÓVEIS - ESCRITÓRIO', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (38, 'MÓVEIS - QUARTO', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (39, 'MÓVEIS - SALA', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (41, 'PORTATEIS - COZINHA E PREPARADORES DE ALIMENTOS', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (42, 'ESPORTE & LAZER - VESTUÁRIO', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (43, 'FASHION - BOLSAS E ACESSORIOS', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (44, 'FASHION - CALÇADOS', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (45, 'FASHION - ROUPA FEMININA', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (47, 'FASHION - ROUPA MASCULINA', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (48, 'FASHION - UNDERWEAR E MODA PRAIA', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (49, 'FUN KITCHEN', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (50, 'GIFT CARDS', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (51, 'LA CUISINE', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (52, 'OPEN BOX', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (53, 'MÓVEIS SALA', '2021-04-13 17:26:14.000000', null, null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (40, 'ESPORTE', '2021-04-13 17:26:14.000000', '2021-04-15 13:45:20.321278', null, 6);
INSERT INTO tars.public."Categorys" ("CategoryID", "Name", "Created_at", "Updated_at", "Deleted_at", "UserID")
VALUES (79, 'Teste', '2021-04-14 14:04:17.309740', '2021-04-15 13:46:14.329228', null, 6);

INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (12, 'Cooktop 5 Bocas Gás Glass Brasil 5GG 70 94708/501 Tramontina', 'Tramontina', 'Lorem ipsum', 0, 799, 639,
        '7894693034069', '73211100', 12, 16, 77, 50, 11.2, 6, 11, '2021-04-13 14:12:54.175541', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (13, 'Rotulador Eletrônico PT-70BM BROTHER', 'Brother', 'Lorem ipsum', 0, 169, 132.9, '12502619673', '84729099',
        12, 21, 22, 8, 0.6, 6, 11, '2021-04-13 14:12:54.188931', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (14, 'Rotulador Eletrônico PT-80 BROTHER', 'Brother', 'Lorem ipsum', 0, 259, 194.9, '12502617082', '84729099',
        12, 15.3, 10.5, 6, 0.6, 6, 11, '2021-04-13 14:12:54.243996', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (15, 'Impressora Laser Mono Wireless Phaser 3260 110V XEROX', 'Xerox', 'Lorem ipsum', 0, 899, 749, '95205863093',
        '84433233', 12, 34, 46, 42, 9.4, 6, 11, '2021-04-13 14:12:54.291694', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (16, 'Multifuncional Laser Mono Workcentre 3215/NI 110V XEROX', 'Xerox', 'Lorem ipsum', 0, 1499, 1199,
        '95205863161', '84433113', 12, 52, 49, 44, 13.9, 6, 11, '2021-04-13 14:12:54.365561', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (17, 'Ventilador de Teto Petit 127V Branco Ventisol', 'Ventisol', 'Lorem ipsum', 1, 199, 189, '7898461963360',
        '84145990', 12, 16, 24, 43.5, 4.3, 6, 11, '2021-04-13 14:12:54.418089', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (18, 'Impressora Epson TM-T20 BRCB10081 Térmica Não Fiscal com Guilhotina USB Qr Code', 'Epson', 'Lorem ipsum',
        0, 718.15, 531.96, '10343914018', '84433239', 12, 24, 24, 20, 2.4, 6, 11, '2021-04-13 14:12:54.478231', null,
        null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (19, '"TV LED 32"" HD Samsung Série 4 UN32J4000AGXZD 2 HDMI Conversor Digital"', 'Samsung', 'Lorem ipsum', 0,
        1168.7, 964.94, '7892509083911', '85287200', 12, 51, 81, 13, 5.1, 6, 11, '2021-04-13 14:12:54.531337', null,
        null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (20, '"Smart TV LED 32"" HD Samsung UN32J4300AGXZD 2 HDMI Wi-Fi Integrado"', 'Samsung', 'Lorem ipsum', 0, 1099,
        1019, '7892509083904', '85287200', 12, 51, 80, 13, 5.2, 6, 11, '2021-04-13 14:12:54.636287', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (21, '"TV LED 32"" HD Samsung 32ND450 2 HDMI 1 USB Conversor Digital"', 'Samsung', 'Lorem ipsum', 2, 1349, 1299,
        '7892509079099', '85287200', 12, 50.3, 12.7, 92.4, 5.53, 6, 11, '2021-04-13 14:12:54.646569', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (22, 'Multifuncional Jato de tinta Colorida DeskJet Ink Advantage 2136 F5S30A HP', 'Hp', 'Lorem ipsum', 0,
        485.31, 373.31, '889296132462', '84433111', 12, 20, 48, 19, 4.48, 6, 11, '2021-04-13 14:12:54.704930', null,
        null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (23, 'Impressora Multifuncional Brother DCP- 1617NW Laser Mono Wireless 110V', 'Brother', 'Lorem ipsum', 0, 1599,
        1499, '12502639800', '84433113', 12, 34, 28.3, 38.5, 10.7, 6, 11, '2021-04-13 14:12:54.795972', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (24, 'Climatizador e Umidificador de Ar Frio 110V FCE-75 ELGIN', 'Elgin', 'Lorem ipsum', 159, 629, 499,
        '7897013551406', '84796000', 12, 71, 30, 37, 7.3, 6, 11, '2021-04-13 14:12:54.969505', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (25, 'Cabo 2RCA + 2RCA 1.5m CV022 VINIK', 'Vinik', 'Lorem ipsum', 0, 2.79, 2.14, '7898547285812', '85444200', 12,
        4.5, 15, 18.5, 0.55, 6, 11, '2021-04-13 14:12:54.983138', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (26, 'Micro-Ondas 21L Branco ST254W 127V PANASONIC', 'Panasonic', 'Lorem ipsum', 0, 419, 324, '7896067221891',
        '85165000', 12, 32, 50, 39, 12.5, 6, 11, '2021-04-13 14:12:55.045203', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (27, 'Toner Preto 92298X HP', 'Hp', 'Lorem ipsum', 5, 118.79, 91.38, '88698173411', '84439933', 12, 35.3, 15.5,
        24.6, 2, 6, 11, '2021-04-13 14:12:55.122858', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (28, 'Impressora Multifuncional Xerox WorkCentre 3025/NI Laser Mono Wireless 110V', 'Xerox', 'Lorem ipsum', 0,
        1199, 899, '95205863147', '84433113', 12, 46, 50, 45, 12.7, 6, 11, '2021-04-13 14:12:55.188855', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (30, 'Assador Elétrico Rotativo Vitta Smart 3 Espetos 127V ARKE', 'Arke', 'Lorem ipsum', 0, 660, 499,
        '7898338262862', '84198190', 12, 51, 61, 39, 16.8, 6, 11, '2021-04-13 14:12:55.316170', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (31, 'Multifuncional Laser Mono Wireless LaserJet Pro M426dw F6W13A#696 110V HP', 'Hp', 'Lorem ipsum', 0, 1999,
        1749, '889296050742', '84433113', 12, 63.4, 32.5, 43, 15.5, 6, 11, '2021-04-13 14:12:55.375474', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (32, 'TV LED 43'' Full HD LG 43LX300C 1 HDMI 1 USB Conversor Digital', 'Lg', 'Lorem ipsum', 0, 2225, 1576,
        '7893299908842', '85287200', 12, 66.55, 15.1, 105.7, 10.3, 6, 11, '2021-04-13 14:12:55.452081', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (33, 'Multifuncional Tanque de Tinta Colorida DCP-T300 Brother', 'Brother', 'Lorem ipsum', 0, 1146.09, 719,
        '12502640493', '84433111', 12, 18, 40, 50, 8, 6, 11, '2021-04-13 14:12:55.506022', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (34, 'Impressora Fotográfica Tanque de Tinta Colorida L1800 Epson', 'Epson', 'Lorem ipsum', 0, 3699, 3639,
        '10343913363', '84433231', 12, 31.5, 37, 94, 12.2, 6, 11, '2021-04-13 14:12:55.575122', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (35, '"Smart TV LED 40"" Full HD Samsung UN40J5200 2 HDMI 1 USB Wi-Fi Integrado Conversor Digital"', 'Samsung',
        'Lorem ipsum', 0, 1739, 1449, '7892509082495', '85287200', 12, 58.8, 12, 109.8, 8, 6, 11,
        '2021-04-13 14:12:55.632476', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (36, 'Impressora Tanque de Tinta Colorida Wireless EcoTank L805 Epson', 'Epson', 'Lorem ipsum', 0, 2244.88, 1899,
        '10343924390', '84433231', 12, 57.2, 29, 53.7, 6.2, 6, 11, '2021-04-13 14:12:55.695941', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (38, 'Impressora Multifuncional Canon Pixma Maxx Tinta G3100 Tanque de Tinta Colorida Wireless', 'Canon',
        'Lorem ipsum', 0, 1049, 999, '7898576034689', '84433111', 12, 25, 48, 53, 9.2, 6, 11,
        '2021-04-13 14:12:55.834336', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (39, '"Smartphone Alcatel One Touch Pixi4 8GB Dual Chip 3G Tela 6"" Android 5.1 Preto"', 'Alcatel',
        'Lorem ipsum', 0, 519, 399, '7898552003814', '85171231', 12, 17.6, 4.3, 9.4, 0.48, 6, 11,
        '2021-04-13 14:12:55.899187', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (40, '"TV LED 32"" HD LG 32LW300C 1 HDMI 1 USB Conversor Digital"', 'Lg', 'Lorem ipsum', 0, 1055, 879,
        '7893299908835', '85287200', 12, 50.5, 13.4, 79.5, 6.2, 6, 11, '2021-04-13 14:12:55.961133', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (37, '"Monitor Gamer LED 24"" AOC 144Hz 1ms Full HD 1 HDMI G2460PF"', 'AOC', 'Lorem ipsum', 2, 5.55, 1289,
        '7898930919881', '85285220', 12, 42.3, 18.7, 69.3, 8.4, 6, 13, '2021-04-13 14:12:55.774387',
        '2021-04-14 17:37:23.949923', null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (29, 'Gravador DVD Interno 24x SATA GH24NSC0-I LG', 'Lg', 'Lorem ipsum', 0, 108, 90, '58231311938', '84717029',
        12, 15.5, 4.13, 14.6, 0.7, 6, 11, '2021-04-13 14:12:55.200756', '2021-04-14 21:17:16.948016', null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (41, '"Smart TV LED 48"" Full HD Samsung 48J5200 2 HDMI 1 USB Wi-Fi Integrado Conversor Digital"', 'Samsung',
        'Lorem ipsum', 0, 2834, 2269.32, '7892509078382', '85287200', 12, 63.87, 7.39, 109.87, 9.7, 6, 11,
        '2021-04-13 14:12:55.993696', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (42, 'Impressora Jato de Tinta Color Wireless Officejet 8210 D9L63A Bivolt HP', 'Hp', 'Lorem ipsum', 0, 1294.65,
        959, '889894411037', '84433231', 12, 16, 19, 49.6, 8.6, 6, 11, '2021-04-13 14:12:56.030598', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (43, 'Servidor TS150 E3-1225V5 70LVA002BN Lenovo', 'Lenovo', 'Lorem ipsum', 0, 3539.98, 3149, '190576147596',
        '84715010', 12, 50, 22, 30, 11.2, 6, 11, '2021-04-13 14:12:56.091564', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (44, '"Tela De Projeção Retrátil 100"" TRVS100 Sumay"', 'Sumay', 'Lorem ipsum', 0, 599, 419, '7898508261381',
        '90106000', 12, 13, 2.25, 13, 9, 6, 11, '2021-04-13 14:12:56.170282', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (45, '"TV LED 32"" TCL HD 2 HDMI 1 USB Conversor Digital 32L1500"', 'Toshiba', 'Lorem ipsum', 0, 1199, 879,
        '7899968300146', '85287200', 12, 50.6, 14.6, 80.1, 6.32, 6, 11, '2021-04-13 14:12:56.281363', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (46, 'Multifuncional Laser Mono Xpress SL-M2070 Samsung', 'Samsung', 'Lorem ipsum', 0, 1049, 999, '192018143012',
        '84433113', 12, 35.96, 25.3, 40.6, 10.2, 6, 11, '2021-04-13 14:12:56.359101', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (47, 'Impressora Multifuncional HP Deskjet Ink Advantage 2135 Jato de Tinta Colorida Bivolt', 'Hp',
        'Lorem ipsum', 0, 249, 179, '889296132332', '84433111', 3, 42.5, 14.09, 30.4, 5, 6, 11,
        '2021-04-13 14:12:56.422571', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (48, 'Telefone Sem Fio Elgin com Identificador de Chamada TSF7600 Branco', 'Elgin', 'Lorem ipsum', 0, 149, 109,
        '7897013558993', '85171100', 12, 6, 15, 18, 0.45, 6, 11, '2021-04-13 14:12:56.512985', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (49, 'Telefone Sem Fio Elgin com Identificador de Chamada TSF7500', 'Elgin', 'Lorem ipsum', 0, 189, 129,
        '7897013558962', '85171100', 12, 8.8, 13.3, 17.5, 0.55, 6, 11, '2021-04-13 14:12:56.626723', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (50, 'Panela de Pressão Elétrica PED-01 4L Preto e Prata 127V Agratto', 'Agratto', 'Lorem ipsum', 0, 254.67,
        188.64, '7898461965159', '85167910', 12, 34, 32, 32, 3.65, 6, 11, '2021-04-13 14:12:56.638593', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (51, 'Coifa de Parede Agratto 60cm Aço Escovado em Inox CPV60 01 127V', 'Agratto', 'Lorem ipsum', 0, 719, 599,
        '7898461964060', '84146000', 12, 57, 65, 46, 16.5, 6, 11, '2021-04-13 14:12:56.693850', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (52, 'Coifa de Parede Agratto 90cm Aço Escovado em Inox CPV90-01 127V', 'Agratto', 'Lorem ipsum', 0, 800, 689,
        '7898461964084', '84146000', 12, 57, 95, 46, 19.1, 6, 11, '2021-04-13 14:12:56.752543', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (53, 'Ventilador de Parede 50cm Premium Preto Bivolt Ventisol', 'Ventisol', 'Lorem ipsum', 0, 199, 159,
        '7898461960505', '84145990', 12, 52, 20, 51, 2.9, 6, 11, '2021-04-13 14:12:56.898741', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (54, 'Ventilador de Parede 50cm NEW Preto 127V Ventisol', 'Ventisol', 'Lorem ipsum', 1, 199, 149,
        '7898461962547', '84145990', 12, 51, 13, 50, 2.56, 6, 11, '2021-04-13 14:12:56.975297', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (55, 'Ventilador de Parede 50cm NEW Preto 220V Ventisol', 'Ventisol', 'Lorem ipsum', 0, 189, 149,
        '7898461962554', '84145990', 12, 51, 13, 50, 2.56, 6, 11, '2021-04-13 14:12:57.132583', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (56, 'Ventilador de Parede 50cm NEW Branco 127V Ventisol', 'Ventisol', 'Lorem ipsum', 0, 170, 119,
        '7898461962585', '84145990', 12, 51, 13, 51, 2.55, 6, 11, '2021-04-13 14:12:57.147526', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (57, 'Ventilador de Coluna Turbo 6 Premium 40cm Branco 127V Ventisol', 'Ventisol', 'Lorem ipsum', 0, 170, 139,
        '7898461965517', '84145190', 12, 46, 14, 45, 3.22, 6, 11, '2021-04-13 14:12:57.213877', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (58, 'Ventilador de Coluna Turbo 6 Premium 40cm Branco 220V Ventisol', 'Ventisol', 'Lorem ipsum', 0, 160, 129,
        '7898461965524', '84145190', 12, 46, 14, 45, 3.22, 6, 11, '2021-04-13 14:12:57.319523', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (59, 'Ventilador de Coluna Turbo 6 Premium 40cm Preto 127V Ventisol', 'Ventisol', 'Lorem ipsum', 2, 179, 139,
        '7898461965111', '84145190', 12, 46, 14, 45, 3.22, 6, 11, '2021-04-13 14:12:57.330978', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (60, 'Climatizador Evaporativo Slim CLE Premium 127V CLE-01 Ventisol', 'Ventisol', 'Lorem ipsum', 0, 220, 179,
        '7898461963872', '84796000', 12, 78, 27, 45, 7.95, 6, 11, '2021-04-13 14:12:57.387663', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (61, '"TV LED 49"" LG Full HD 1 HDMI 1 USB Conversor Digital 49LW300C"', 'Lg', 'Lorem ipsum', 1, 2249, 2179,
        '7893299908859', '85287200', 12, 76, 15.2, 0.12, 14.1, 6, 11, '2021-04-13 14:12:57.434917', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (62, 'Impressora Multifuncional HP Deskjet Ink Advantage 3776 J9V88AAK4 Jato de Tinta Color Wireless', 'Hp',
        'Lorem ipsum', 4, 750.94, 600.75, '889894929969', '84433111', 12, 45, 17, 24.6, 3.06, 6, 11,
        '2021-04-13 14:12:57.509424', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (63, '"TV LED 32"" HD TCL 32L1600 2 HDMI 1 USB Conversor Digital"', 'Semp Toshiba', 'Lorem ipsum', 1, 1199, 879,
        '7899968300313', '85287200', 12, 51, 81, 13, 5.3, 6, 11, '2021-04-13 14:12:57.636635', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (64, '"TV LED 32"" HD Semp Toshiba L32D2900 3 HDMI 1 USB Conversor Digital"', 'Semp Toshiba', 'Lorem ipsum', 0,
        1199, 879, '7899968300290', '85287200', 12, 50, 13, 81, 5.1, 6, 11, '2021-04-13 14:12:57.647791', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (65, 'Micro-ondas 20L Branco 127V MTD30 Electrolux', 'Electrolux', 'Lorem ipsum', 0, 499, 479, '7896584062052',
        '85165000', 12, 32, 40, 50, 12, 6, 11, '2021-04-13 14:12:57.764565', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (66, 'Impressora Multifuncional Jato de Tinta Color Wireless Advantage 4535 Bivolt HP', 'Hp', 'Lorem ipsum', 0,
        599, 424.9, '889296228622', '84433111', 12, 44.5, 16.8, 45.01, 5.3, 6, 11, '2021-04-13 14:12:57.776717', null,
        null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (67, 'Impressora Laser Mono Wireless Jet Pro M102w 110V HP', 'Hp', 'Lorem ipsum', 0, 827.82, 789, '889894212474',
        '84433233', 12, 29.8, 40, 25, 5.9, 6, 11, '2021-04-13 14:12:57.832367', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (68, 'Impressora Multifuncional Jato de Tinta Color Wireless Advantage 4675 Bivolt HP', 'Hp', 'Lorem ipsum', 0,
        699, 489, '889296269885', '0', 12, 19, 44.5, 36, 6.5, 6, 11, '2021-04-13 14:12:57.876094', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (69, 'Telefone Sem Fio Panasonic com Identificador de Chamadas KX-TGB110LBB', 'Panasonic', 'Lorem ipsum', 0, 149,
        91.9, '5025232815043', '85171100', 12, 11.5, 17, 9, 0.36, 6, 11, '2021-04-13 14:12:57.913238', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (70, 'Micro-ondas 20 Litros Espelhado Philco PME22 110V Branco', 'Philco', 'Lorem ipsum', 0, 419, 349,
        '7899466406074', '85165000', 12, 28.5, 35, 49, 11.57, 6, 11, '2021-04-13 14:12:58.034200', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (71, 'Micro-ondas 25 Litros Espelhado Philco PME25 110V Prata', 'Philco', 'Lorem ipsum', 0, 449, 429,
        '7891356033346', '85165000', 12, 33, 43, 54.3, 14.73, 6, 11, '2021-04-13 14:12:58.044811', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (72, 'Impressora Multifuncional HP DeskJet GT 5822 Tanque de Tinta Colorida Wireless Bivolt', 'Hp',
        'Lorem ipsum', 0, 999, 679, '190781067962', '84433111', 12, 52.4, 31, 15.8, 4.5, 6, 11,
        '2021-04-13 14:12:58.161885', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (73, 'Telefone Sem Fio Elgin Com identificador de Chamadas e Ramal TSF-8002 Preto', 'Elgin', 'Lorem ipsum', 0,
        249, 159, '7897013565502', '85171100', 12, 25, 16, 20, 0.5, 6, 11, '2021-04-13 14:12:58.228010', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (75, '"Smartphone LG K10 Power 32GB Dual Chip 4G 5.5"" Câmera 13MP Câmera Frontal 5MP Android 7.0 Indigo"', 'Lg',
        'Lorem ipsum', 0, 1146, 849, '7893299908545', '85171231', 12, 15, 8, 8, 0.4, 6, 11,
        '2021-04-13 14:12:58.337740', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (76, 'Smart TV LED 32'' HD Semp TCL L32S4900S 3 HDMI 2 USB Wi-Fi Integrado Conversor Digital', 'Semp Toshiba',
        'Lorem ipsum', 0, 1099, 849, '7899968300368', '85287200', 12, 50.8, 13, 81.3, 5.3, 6, 11,
        '2021-04-13 14:12:58.405858', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (77, 'Micro-ondas 20 Litros Philco Tecla Fácil Cozinhar PMS24 Branco 127V', 'Philco', 'Lorem ipsum', 0, 441.94,
        327.36, '7899466406050', '85165000', 12, 29, 36.7, 49.8, 11.57, 6, 11, '2021-04-13 14:12:58.565175', null,
        null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (78, 'Micro-ondas 30 Litros Philco Espelhado PME31 127V', 'Philco', 'Lorem ipsum', 0, 530, 479, '7899466406173',
        '85165000', 12, 36.3, 46.7, 60.5, 18.03, 6, 11, '2021-04-13 14:12:58.578299', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (79, 'Panela de Arroz Elétrica Britânia PA10 Prime 10 Xícaras 127V', 'Britania', 'Lorem ipsum', 0, 120, 109,
        '7891356054976', '85167910', 12, 28.5, 29, 29, 2.86, 6, 11, '2021-04-13 14:12:58.636532', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (80, 'Impressora Multifuncional HP LaserJet Pro M130fw Laser Mono Wireless 110V', 'Hp', 'Lorem ipsum', 0, 1599,
        1249, '725184117305', '84433113', 12, 32.2, 42, 41, 16.3, 6, 11, '2021-04-13 14:12:58.776867', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (81, 'Impressora Multifuncional Epson Ecotank L395 Jato de Tinta Colorida Wireless Bivolt', 'Epson',
        'Lorem ipsum', 0, 1199, 889, '10343931787', '84433111', 12, 30, 44, 52, 4.9, 6, 11,
        '2021-04-13 14:12:58.788734', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (82, 'Impressora Multifuncional Epson Ecotank L495 Jato de Tinta Colorida Wireless Bivolt', 'Epson',
        'Lorem ipsum', 0, 1199, 889, '10343931817', '0', 12, 14.5, 48.2, 30, 4.5, 6, 11, '2021-04-13 14:12:58.861032',
        null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (83, 'Micro-Ondas 27L Electrolux Ponto Certo MEP37 Branco 127V', 'Electrolux', 'Lorem ipsum', 0, 492.41, 364.75,
        '7896584060638', '85165000', 12, 31, 41.8, 51.2, 13.1, 6, 11, '2021-04-13 14:12:58.891408', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (84, 'Ar Condicionado Split 9.000 BTUs Frio Agratto Confort One ACS9F-R4 220V', 'Agratto', 'Lorem ipsum', 0,
        1320, 1099, '7898461965425', '84151011', 12, 85.1, 59, 33.5, 38.5, 6, 11, '2021-04-13 14:12:58.923030', null,
        null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (85, 'Forno Elétrico 50L Britânia 066101020 Preto 110V', 'Britania', 'Lorem ipsum', 0, 440, 389, '7891356012877',
        '85166000', 12, 41, 44.2, 63.8, 10.73, 6, 11, '2021-04-13 14:12:59.030194', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (86, 'Ar Condicionado Split 12.000 BTUs Frio Agratto Confort One ACS12F-R4 220V', 'Agratto', 'Lorem ipsum', 0,
        1650, 1189, '7898461965005', '84151011', 12, 86.5, 59, 35.8, 40, 6, 11, '2021-04-13 14:12:59.110270', null,
        null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (87, 'Impressora Multifuncional Samsung Xpress SL-C480FW Laser Color Wireless 110V', 'Samsung', 'Lorem ipsum', 0,
        2199, 1598, '191628385157', '84433115', 12, 40, 36, 33, 14.5, 6, 11, '2021-04-13 14:12:59.146225', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (88, 'Forno Elétrico 46L Philco 056101046 Preto e Prata 110V', 'Philco', 'Lorem ipsum', 0, 360, 329,
        '7891356064555', '85166000', 12, 39.5, 49, 60.8, 9.08, 6, 11, '2021-04-13 14:12:59.210247', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (89, 'Filtro de Linha 4 Tomadas SMS 64100 Bivolt', 'Sms', 'Lorem ipsum', 0, 16.47, 14.97, '7897020622731',
        '84733099', 12, 0.06, 0.27, 0.12, 0.3, 6, 11, '2021-04-13 14:12:59.273207', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (90, 'Filtro de Linha 4 Tomadas SMS 62328 Bivolt', 'Sms', 'Lorem ipsum', 0, 34, 29.9, '7897020631887',
        '84149020', 0, 37, 5, 12, 0.29, 6, 11, '2021-04-13 14:12:59.336358', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (91, 'Impressora HP LaserJet Pro M501dn Laser Mono 110V', 'Hp', 'Lorem ipsum', 0, 4432.52, 2999, '8892962585060',
        '84433115', 12, 0.46, 0.39, 0.49, 13.84, 6, 11, '2021-04-13 14:12:59.400163', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (92, 'Micro-ondas 31L Electrolux com Painel Integrado MI41T Branco 110V', 'Electrolux', 'Lorem ipsum', 0, 550.85,
        459, '7896584066111', '85165000', 12, 34.8, 45.7, 55.4, 15.7, 6, 11, '2021-04-13 14:12:59.447496', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (93, '"Smart TV LED 40"" Full HD Samsung LH40RBHBBBG/ZD 2 HDMI USB Wi-Fi Integrado Conversor Digital"',
        'Samsung', 'Lorem ipsum', 0, 1818.7, 1690.86, '7892509103047', '85287200', 12, 60.9, 12.5, 110.3, 9, 6, 11,
        '2021-04-13 14:12:59.504798', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (95, '"Smartphone Samsung Galaxy J5 Prime 32GB Dual Chip 4G 5"" Câmera 13MP Selfie 5MP Android 6.0 Preto"',
        'Samsung', 'Lorem ipsum', 0, 1079, 799, '7892509093668', '85171231', 12, 15, 7.7, 4.7, 0.35, 6, 11,
        '2021-04-13 14:12:59.620323', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (96, '"Smartphone Samsung Galaxy J5 Prime 32GB Dual Chip 4G 5"" Câmera 13MP Selfie 5MP Android 6.0 Dourado"',
        'Samsung', 'Lorem ipsum', 0, 1079, 799, '7892509093651', '85171231', 12, 15, 7.8, 4.7, 0.35, 6, 11,
        '2021-04-13 14:12:59.693535', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (97, 'Impressora Multifuncional HP Deskjet Ink Advantage 2676 Colorida Wireless Bivolt', 'Hp', 'Lorem ipsum', 0,
        510.49, 484, '190780932315', '84433111', 12, 45, 33, 14, 3.42, 6, 11, '2021-04-13 14:12:59.730055', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (98, 'Impressora Multifuncional Canon Maxify MB2710 Jato de Tinta Colorida Wireless 110V', 'Canon',
        'Lorem ipsum', 0, 1686.15, 1249, '4549292051056', '84433111', 12, 46, 26, 46, 10, 6, 11,
        '2021-04-13 14:12:59.760753', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (99, 'Smart TV LED 43'' Full HD Panasonic TC-43ES630B 3 HDMI 2 USB Wi-Fi Integrado Conversor Digital',
        'Panasonic', 'Lorem ipsum', 0, 2499, 1669, '7896067213070', '85287200', 12, 60, 15, 60, 10, 6, 11,
        '2021-04-13 14:12:59.793710', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (100, 'Forno Elétrico 44L Chamalux Branco e Preto 110V', 'Chamalux', 'Lorem ipsum', 0, 299, 277.17,
        '7898241580152', '85166000', 12, 48, 50, 50, 17.6, 6, 11, '2021-04-13 14:12:59.856342', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (101, 'Mouse Gamer Mesh Gear Horus USB 2.0 óptico 4.000dpi LED RGB 4 botões 976 MESH', 'Mesh', 'Lorem ipsum', 0,
        82.79, 63.69, '7892635046934', '84716053', 12, 12.5, 4, 8.7, 0.1, 6, 11, '2021-04-13 14:13:00.058076', null,
        null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (102, 'Teclado Gamer Mecânico Mesh Gear Balder USB LED RGB GATERON RED USA B06S BALDER', 'Mesh', 'Lorem ipsum',
        0, 249, 129, '7892635046927', '84716052', 12, 23, 5, 10, 1.1, 6, 11, '2021-04-13 14:13:00.069383', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (103, 'Teclado Gamer Mecânico Mesh Gear Forseti USB LED RGB GATERON RED USA F01S FORSETI', 'Mesh', 'Lorem ipsum',
        0, 224.4, 166.22, '7892635046910', '84716052', 12, 20, 5, 10, 1, 6, 11, '2021-04-13 14:13:00.126051', null,
        null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (104, 'Cooktop Chamalux Acendimento Inteligente 4 Bocas à Gás Mesa em Vidro Temperado', 'Chamalux',
        'Lorem ipsum', 0, 383.01, 283.71, '7898241580046', '73211100', 12, 14, 48, 60, 7.9, 6, 11,
        '2021-04-13 14:13:00.233926', null, null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (94, '"Smart TV LED 28"" HD LG 28MT49S-PS 2 HDMI USB Wi-Fi Integrado Conversor Digital"', 'Lg', 'Lorem ipsum', 0,
        1289.99, 888.99, '7893299907371', '85287200', 12, 45, 11.8, 79.6, 6.2, 6, 11, '2021-04-13 14:12:59.557446',
        '2021-04-14 17:38:08.492464', null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (105, 'Teste Dev', 'Samsung', 'produto teste', 99, 10, 1000, '101010', '101010', 12, 10, 10, 15, 10, 6, 53, null,
        '2021-04-15 11:39:25.800943', null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (74, '"Smartphone LG K10 Novo 32GB Dual Chip 4G 5.3"" Câmera 13MP Câmera Frontal 5MP Android 7.0 Dourado"', 'Lg',
        'Lorem ipsum', 0, 5.5, 10, '7893299908422', '85171231', 12, 15, 8, 5, 0.33, 6, 11, '2021-04-13 14:12:58.276536',
        '2021-04-14 16:46:06.160198', null);
INSERT INTO tars.public."Products" ("ProductID", "Title", "Brand", "Description", "Stock", "PriceDefault", "PriceOffer",
                                    ean,
                                    ncm, "Warranty", "Height", "Lenght", "Width", "Weight", "UserID", "CategoryID",
                                    "Created_at", "Updated_at", "Deleted_at")
VALUES (108, 'Teste', 'teste', '1', 1, 11.11, 11.11, '12dsa', '123d', 3, 123, 123, 123, 123, 6, 79, null, null, null);

