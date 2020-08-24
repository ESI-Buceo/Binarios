#!/bin/bash



clear
read -p "ingrese el nombre del usuario a cambiar:" nombre
read -p "ingresa el nombre de usuario nuevo:" nombre2
sudo usermod -l $nombre2 $nombre
echo "El nombre ah sido cambiado:"
sleep 3;
echo "Ingrese una nueva contraseña:"
sudo passwd $nombre2
sleep 3;

echo "su contraseña ah sido cambiado"


clear