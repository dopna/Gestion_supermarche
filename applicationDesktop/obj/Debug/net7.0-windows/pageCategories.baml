   M S B A M L   `   `   `  ����M  IapplicationDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:applicationDesktopapplicationDesktop  5   	   '    !applicationDesktop.pageCategories   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   2local clr-namespace:applicationDesktop     5   	     � Title$  pageCategories��5   	   $	��450��6    $	��800��6-   .��5	      � .+�5
   
   � 
��� ���$	��150��6#   $
��Left=�6/   .+�5      �� .+�5      �� $��Articles��6   $��Center=�6+   $��20(�6I   $
��0,60q�6W   �� 5      $��
Categories��6   $��Center=�6.   $��20(�6L   $��10,-40q�6Z   �� 5      $��Vendeurs��6   $��Center=�6,   $��20(�6J   $��10,10q�6X   �� 5      $��Facturations��6   $��Center=�60   $��20(�6N   $
��1  0q�6\   5      5      � 5   
   
�������$��	150,0,0,0q�6#   $	��Top=�66   $��50��6N   .+�5      �� $��Gestions des Categories��6   $��20(�66   $��Center=�6D   $��0��6a   5      �� 5   
   $
��Left=�6   $��
200,55,0,0q�6/   $
��Wrap=�6C   $��Nom de la Categorie��6W   $	��Top=�6r   $��42��6�   $	��230��6�   $��20(�6�    �� TextAlignment$ Center=�6�   �� 5   
   -   5         ��Name$ 
textNomCat��5      $
��Left=�6&   $��25��6A   $��
220,86,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6v   $	��220��6�   
���   �$��26(�6�    �� TextAlignment$
 Left=�6�   
�������6�   �� 5   
   $��	Remarques��6   $	��Top=�6&   $��20(�6?   $ Center=�6M   $��
290,55,0,0q�6d   6z   �� 5   
   -   5        $ textRemarques��5      $
��Left=�6)   $��25��6D   $��
500,86,0,0q�6P   $
 Wrap=�6d   $	��Top=�6y   $	��220��6�   
���   �$��26(�6�   $
 Left=�6�   
�������6�   �� 5   
   -   5         ��Name$ btnEnregistrer��5   %   
��� ���$��Enregistrer��6=   $
��Left=�6S   $	��Top=�6n   $	��100��6�   $��30��6�   $��287,150,0,0q�6�   �� 5   
   -   5        $ btnModifier��5   %   
��� ���$��Modifier��6:   $
��Left=�6M   $	��Top=�6h   $	��100��6�   $��30��6�   $��420,150,0,0q�6�   �� 5    
   -   5        $ btnSupprimer��5    %   
��� ���$��	Supprimer��6;   $
��Left=�6O   $	��Top=�6j   $	��100��6�   $��30��6�   $��560,150,0,0q�6�   �� 5!   
   $
��Left=�6   $��400,210,0,0q�6/   $
��Wrap=�6D   $��Liste des Categorie��6X   $	��Top=�6s   $��42��6�   $	��267��6�   $��20(�6�   $ Center=�6�   �� 5"   
   -   5         ��Name$ 	categorie��5"      $��Right=�6&   $��25��6B   $��10,250,160,0q�6N   $	��Top=�6d   $	��180��6|   
���   �$��26(�6�   .@�5#      �� $��Option 1��6   �� 5$      $��Option 2��6   �� 5%      $��Option 3��6   5&      5'      5(      