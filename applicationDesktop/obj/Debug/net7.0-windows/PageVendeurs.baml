   M S B A M L   `   `   `  ����M  IapplicationDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:applicationDesktopapplicationDesktop  5   	   %    applicationDesktop.PageVendeurs   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1fa"http://schemas.fontawesome.com/wpf     5   
   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   2local clr-namespace:applicationDesktop     5   	     � Title$  PageVendeurs��5	   	   $	��450��6   $	��800��6+   .��5
      � .+�5   
   � 
��� ���$	��150��6#   $
��Left=�6/   .+�5      �� .+�5      ��  �� Orientation$ Vertical=�6   $
��0,60q�64   .+�5      �� $��Articles��6   $��Center=�6/   $��20(�6L   $��10q�6Z   �� 5      $��
Categories��6   $��Center=�62   $��20(�6P   $��10q�6^   �� 5      $��Vendeurs��6   $��Center=�60   $��20(�6N   $��10,10q�6\   �� 5      $��Facturations��6   $��Center=�64   $��20(�6R   $��10q�6`   5      �� 5      $��Center=�6   $��20(�67   
��� ���$��10,160q�6Y   .��6i   Deconnexion6v   5      5      � 5   
   
�������$��	150,0,0,0q�6#   $	��Top=�66   $��50��6N   .+�5      �� $��Gestions des Vendeurs��6   $��20(�64   $��Center=�6B   $��0��6_   5      �� 5   
   $��1��6   $��Center=�6"   $��50q�6?   .+�5      �� $��Nom du Vendeur��6   $��20(�6-   $��
0,0,320,10q�6;   �� 5      $	��180��6   $��25��6"   $��Center=�6.   $��0,-11,285,0q�6K   5      �� 5   
   $
��Left=�6   $��
352,54,0,0q�6/   $
��Wrap=�6C   $��Pseudo��6W   $	��Top=�6e   $��42��6}   $	��123��6�   $��20(�6�    �� TextAlignment$ Center=�6�   �� 5!   
   -   5         ��Name$ textNom��5!      $
��Left=�6#   $��25��6>   $��
370,87,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6s   $	��180��6�   
���   �$��26(�6�    �� TextAlignment$
 Left=�6�   
�������6�   �� 5#   
   $
��Left=�6   $��
570,55,0,0q�6/   $
��Wrap=�6C   $��Mot de passe ��6W   $	��Top=�6l   $��42��6�   $	��217��6�   $��20(�6�   $ Center=�6�   G� 5$   
   $	��189��6   $��25��6"   $
��Left=�6.   $	��Top=�6I   $��
590,87,0,0q�6a   �� 5&   
   $
��Left=�6   $��
48,110,0,0q�6/   $
��Wrap=�6C   $��Adresse��6W   $	��Top=�6f   $��42��6~   $	��297��6�   $��20(�6�   $ Center=�6�   �� 5(   
   -   5        $ stock��5(      $
��Left=�6!   $��25��6<   $��158,138,0,0q�6H   $
 Wrap=�6]   $	��Top=�6r   $	��180��6�   $��20(�6�   $
 Left=�6�   �� 5)   
   -   5         ��Name$ btnEnregistrer��5)   %   
��� ���$��Enregistrer��6=   $
��Left=�6S   $	��Top=�6n   $	��100��6�   $��30��6�   $��257,190,0,0q�6�   �� 5*   
   -   5        $ btnModifier��5*   %   
��� ���$��Modifier��6:   $
��Left=�6M   $	��Top=�6h   $	��100��6�   $��30��6�   $��397,190,0,0q�6�   �� 5+   
   -   5        $ btnSupprimer��5+   %   
��� ���$��	Supprimer��6;   $
��Left=�6O   $	��Top=�6j   $	��100��6�   $��30��6�   $��547,190,0,0q�6�   �� 5,   
   $��20(�6   $��Center=�6   $��90,240,30,30q�6;   .��6Q   Liste des Vendeurs6e   �� 5-   
   .+�5.      �� -   5        $��VendeursListView��5.      $��200,290,20,10q�6/    �� View 5/      �� 50      .P�51      �� $	��Nom��6)    �� Width$	 120��66   	 �� DisplayMemberBinding	 6B   �� *Nom+�� 52      $��Prénom��6)   $	 120��69   	 6E   �� *Prenom+�� 53      $��Adresse��6)   $	 120��6:   	 6F   �� *	Adresse+�� 54      $��	Telephone��6)   $	 120��6<   	 6H   �� *
Télephone+56      58      59      5<      5=      