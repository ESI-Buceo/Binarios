#!/bin/bash


read -p "Ingrese el nombre del usuario a crear: " nombre
read -p "Ingrese el grupo principal del usuario: " grupo


 sudo useradd -d /home/Utu/Usuarios/$grupo/$nombre -m -s /bin/bash -g $grupo $nombre
 sudo passwd $nombre

                 echo "El usuario ah sido creado"

sleep 5;                                                                                                        