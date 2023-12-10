create table songlist(

id int Primary key ,
songName varchar(100)
)

select * from
insert into songlist(id , songName) values( 2, 'jammus')


drop table ALbum
Drop database DIL
create database DIL
use DIL

create table Album(
SongID int,
SongGener varchar(100),
SongName varchar(100),
SongLocation varchar(200)
);

insert into album values(1,'classic','one last time','ABC');



update album set SongLocation = '../assets/la.mp3' where songid<4
select * from songlist

delete from album where songid=6;
update album set Songlocation='../assets/One-last-time.mp3' where songid=1;

alter table songlist Add SongPath varchar(100)

update songlist set SongPath = '../assets/la.mp3' where id = 1


select* from album