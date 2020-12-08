# Exam
В проекте лежит предложенная для рассмотрения схема базы даннных.
Перед использованием проекта необходимо адаптировать значения авторизации для базы данных
в классе db.
Словари для проверки данных: 

Admin: - таблица с данными об администраторах

+----------+-------------+------+-----+---------+-------+
| Field    | Type        | Null | Key | Default | Extra |
+----------+-------------+------+-----+---------+-------+
| login    | varchar(30) | NO   | PRI | NULL    |       |
| password | varchar(30) | NO   | UNI | NULL    |       |
+----------+-------------+------+-----+---------+-------+

Analiz - таблица с данными о выполняемых анализах 

+-----------------+----------+------+-----+---------+----------------+
| Field           | Type     | Null | Key | Default | Extra          |
+-----------------+----------+------+-----+---------+----------------+
| idanaliz        | int      | NO   | PRI | NULL    | auto_increment |
| uslugi_iduslugi | int      | NO   | MUL | NULL    |                |
| timeStart       | datetime | NO   |     | NULL    |                |
| timeEnd         | datetime | NO   |     | NULL    |                |
+-----------------+----------+------+-----+---------+----------------+

buhg - таблица с данными об бухгалтерах

+----------+-------------+------+-----+---------+-------+
| Field    | Type        | Null | Key | Default | Extra |
+----------+-------------+------+-----+---------+-------+
| login    | varchar(30) | NO   | PRI | NULL    |       |
| password | varchar(30) | NO   | UNI | NULL    |       |
| FIO      | varchar(70) | NO   |     | NULL    |       |
+----------+-------------+------+-----+---------+-------+

company - таблица с данными о компаниях 

+---------+-------------+------+-----+---------+-------+
| Field   | Type        | Null | Key | Default | Extra |
+---------+-------------+------+-----+---------+-------+
| Name    | varchar(50) | NO   | PRI | NULL    |       |
| Address | varchar(70) | NO   |     | NULL    |       |
| INN     | varchar(12) | NO   | UNI | NULL    |       |
| r/s     | varchar(20) | NO   |     | NULL    |       |
| BIC     | varchar(9)  | NO   |     | NULL    |       |
+---------+-------------+------+-----+---------+-------+

doneusl - таблица с выполненными анализами 
+-----------------+-------------+------+-----+---------+-------+
| Field           | Type        | Null | Key | Default | Extra |
+-----------------+-------------+------+-----+---------+-------+
| idDoneUsl       | int         | NO   | PRI | NULL    |       |
| date            | datetime    | NO   |     | NULL    |       |
| analiz_idanaliz | int         | NO   | UNI | NULL    |       |
| laboranti_login | varchar(30) | NO   | MUL | NULL    |       |
+-----------------+-------------+------+-----+---------+-------+

dopusk - таблица для выдачи доступа лаборантам к работе с анализатором.

+-----------------+-------------+------+-----+---------+-------+
| Field           | Type        | Null | Key | Default | Extra |
+-----------------+-------------+------+-----+---------+-------+
| iddopusk        | int         | NO   | PRI | NULL    |       |
| date            | date        | NO   |     | NULL    |       |
| laboranti_login | varchar(30) | NO   | MUL | NULL    |       |
| admin_login     | varchar(30) | NO   | MUL | NULL    |       |
| uslugi_iduslugi | int         | NO   | MUL | NULL    |       |
+-----------------+-------------+------+-----+---------+-------+

history - таблица с историей посещений, доступ к которой имеет администратор 

+-----------------+-------------+------+-----+---------+-------+
| Field           | Type        | Null | Key | Default | Extra |
+-----------------+-------------+------+-----+---------+-------+
| idhistory       | int         | NO   | PRI | NULL    |       |
| Time            | datetime    | NO   |     | NULL    |       |
| Access          | tinyint     | NO   |     | NULL    |       |
| laboranti_login | varchar(30) | YES  | MUL | NULL    |       |
| admin_login     | varchar(30) | YES  | MUL | NULL    |       |
| pacienti_login  | varchar(50) | YES  | MUL | NULL    |       |
| buhg_login      | varchar(30) | YES  | MUL | NULL    |       |
+-----------------+-------------+------+-----+---------+-------+

laboranti - таблица с информацией о лаборантах

+----------+-------------+------+-----+---------+-------+
| Field    | Type        | Null | Key | Default | Extra |
+----------+-------------+------+-----+---------+-------+
| login    | varchar(30) | NO   | PRI | NULL    |       |
| password | varchar(30) | NO   | UNI | NULL    |       |
| FIO      | varchar(70) | NO   |     | NULL    |       |
+----------+-------------+------+-----+---------+-------+

pacienti - таблица с информацией о пациентах. 

+--------------+-------------------------+------+-----+------------+-------+
| Field        | Type                    | Null | Key | Default    | Extra |
+--------------+-------------------------+------+-----+------------+-------+
| login        | varchar(50)             | NO   | PRI | NULL       |       |
| password     | varchar(50)             | NO   | UNI | NULL       |       |
| FIO          | varchar(70)             | NO   |     | NULL       |       |
| date         | date                    | NO   |     | 2000-01-01 |       |
| paspSer      | varchar(4)              | NO   |     | NULL       |       |
| paspNum      | varchar(6)              | NO   |     | NULL       |       |
| phone        | varchar(15)             | NO   | UNI | NULL       |       |
| email        | varchar(45)             | NO   | UNI | NULL       |       |
| polisNum     | varchar(17)             | NO   | UNI | NULL       |       |
| policType    | enum('ОМС','ДМС')       | NO   |     | NULL       |       |
| Company_Name | varchar(50)             | NO   | MUL | NULL       |       |
+--------------+-------------------------+------+-----+------------+-------+

scheta - информация о выставленных счетах. price - значение оплаты

+--------------+-------------+------+-----+---------+-------+
| Field        | Type        | Null | Key | Default | Extra |
+--------------+-------------+------+-----+---------+-------+
| idscheta     | int         | NO   | PRI | NULL    |       |
| date         | date        | NO   |     | NULL    |       |
| price        | tinyint     | NO   |     | 0       |       |
| buhg_login   | varchar(30) | NO   | MUL | NULL    |       |
| Company_Name | varchar(50) | NO   | MUL | NULL    |       |
+--------------+-------------+------+-----+---------+-------+

uslugi - информация о предоставляемых услугах

+----------+----------+------+-----+---------+----------------+
| Field    | Type     | Null | Key | Default | Extra          |
+----------+----------+------+-----+---------+----------------+
| iduslugi | int      | NO   | PRI | NULL    | auto_increment |
| name     | char(50) | NO   | UNI | NULL    |                |
| price    | int      | NO   |     | 1000    |                |
| dayToEnd | int      | NO   |     | 7       |                |
| otcl     | float    | NO   |     | 2.3     |                |
+----------+----------+------+-----+---------+----------------+

zakaz_macro - информация о выставленных счетах компаниях 

+-------------------+---------+------+-----+---------+----------------+
| Field             | Type    | Null | Key | Default | Extra          |
+-------------------+---------+------+-----+---------+----------------+
| idzakaz_MACRO     | int     | NO   | PRI | NULL    | auto_increment |
| date              | date    | NO   |     | NULL    |                |
| status            | tinyint | NO   |     | 0       |                |
| time              | int     | NO   |     | NULL    |                |
| zakaz_MICRO_idusl | int     | NO   | MUL | NULL    |                |
| dateEnd           | date    | NO   |     | NULL    |                |
+-------------------+---------+------+-----+---------+----------------+

zakaz_micro - информация об отдельных услугах из пакета услуг.
+-------------------+-------------+------+-----+---------+----------------+
| Field             | Type        | Null | Key | Default | Extra          |
+-------------------+-------------+------+-----+---------+----------------+
| idusl             | int         | NO   | PRI | NULL    | auto_increment |
| zakaz_NUM         | varchar(45) | NO   |     | NULL    |                |
| Status            | tinyint     | NO   |     | 0       |                |
| DoneUsl_idDoneUsl | int         | NO   | MUL | NULL    |                |
+-------------------+-------------+------+-----+---------+----------------+
