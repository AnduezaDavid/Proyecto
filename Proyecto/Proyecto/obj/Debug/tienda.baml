   M S B A M L   `   `   `  ����C  ?Proyecto, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ProyectoProyecto  5   	       Proyecto.tienda   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Proyecto     5   	     � Title$  tienda��5   	   $	��450��6   $	��800��6%   .��5	      � .+�5
   
   �� $��0��6   
���   �$��50��61   $	��Top=�6=   ._�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��imagenes/f1.png��6   $��Center=�61   $
��Left=�6L   $��10,0,0,0q�6g   �� 5      -   5         ��Name$ TeamsDropDown��5      $
��Left=�62   $	��Top=�6M   $��
100,14,0,0q�6e   $��80��6y   .@�5      �� $��RedBull��6#   �� 5      $��AstonMartin��6#   �� 5      $��Ferrari��6#   5      �� 5      -   5        $��Pilotos��5      $��10,14q�6+   $��57��6:   6E   �� 5      -   5        $��	Circuitos��5      $��
0,14,10,14q�6-   $��67��6A   6L   �� 5      -   5        $��Noticias��5      $��
0,14,10,14q�6,   $��71��6@   6K   �� 5      -   5        $��Tienda��5      $��
0,14,10,14q�6*    J� RenderTransformOrigin$ 1.256,0.487&�6>   $��70��6b   6m   5      5      �� 5   
   
�������$ Vertical=�6,   $��
0,55,0,299q�6C   .+�5      �� $��Bienvenido a Tu Tienda��6   $��18(�66   $
��Bold"�6D   $��Center=�6V   $��Center=�6s   �� 5      -   5        $��Carrito��5      $��10,14q�6'   $��57��66   6A   5       �� 5#   
   -   5        $��productosListBox��5#      $��10,125,10,5q�6*   $��Stretch=�6?   $��Stretch=�6]   ��5$      �� 5%      .R�5&      �� $ Vertical=�6!   $��0,0,0,10q�68   .+�5'      �� $	��100��6:   $	��100��6G   ��6    �� *Imagen+6G   �� 5(      $
��Bold"�6<   ��6$   �� *Nombre+6<   �� 5)      ��6$   �� *Precio+ �� StringFormat$ Precio: {0:C}���� 5*      -   5        $��Detalles��5*   !   
 � Tag 64   �� *Id+6G   5+      5,      5.      �� 51   
   -	   5        $��detallesPanel��51      $y�	Collapsed=�6*   $��10,120,10,10q�6A   $��Stretch=�6W   $��Stretch=�6u   .+�52      �� -
   5        $��detalleImagen��52      $	��200��6)   $	��200��66   �� 53      -   5        $��detalleNombre��53      $
��Bold"�6-   $��16(�6?   �� 54      -   5        $��detalleDescripcion��54      $
��Wrap=�62   �� 55      -   5        $��detallePrecio��55      $
��Bold"�6-   $��14(�6?   56      57      58      