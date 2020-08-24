#!/bin/bash

mysqldump -v --opt --events --routines --triggers --default-character-set=utf8 -u root -p Proyecto > /../Respaldo Base de datos/ProyectoB_Proyecto.sql

echo "El directorio se a copiado correctamente"