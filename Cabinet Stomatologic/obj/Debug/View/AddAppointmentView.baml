   M S B A M L   `   `   `  ����O  KCabinet Stomatologic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Cabinet_Stomatologic.ViewCabinet_Stomatologic.View  5      2    ,Cabinet_Stomatologic.View.AddAppointmentView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:Cabinet_Stomatologic.View     5      .��5	      � .+�5
   
   �� $
��Left=�6   $��70��6�   $��	75,60,0,0q�6�   $	��Top=�6�   $	��360��6�     �� SelectedItem  6.   �� *SelectedPatient+��6W   �� *ListPatients+ �� UpdateSourceTrigger$ PropertyChanged=� �� View 5      �� 5      .P�5      �� $��Patient��6%    �� Width$. (200                                     ��66    �� DisplayMemberBinding 5   '   �� *
fullname+$ PropertyChanged=�5      5      �� 5   
   $
��Left=�6   $��75��6{   $��
75,195,0,0q�6�   $	��Top=�6�   $	��360��6�   ��6.   �� *ListDoctors+  6R   �� *SelectedDoctor+ 5      �� 5      .P�5      �� $��Doctor��6%   $. (200                                     ��65    5   '   �� *
fullname+$ PropertyChanged=�5      5      �� 5   
   $
��Left=�6d   $	��130��6   $��
75,275,0,0q�6�   $	��Top=�6�   $	��360��6�   $ �� IsSynchronizedWithCurrentItem$ FalseY�6�   ��6   �� *ProcedureList+  69   �� *SelectedProcedure+ 5      �� 5      .P�5      �� $��	Procedure��6%   $. (200                                     ��68    5    '   �� *nameProcedure+$ PropertyChanged=��� 5!      $��Price��6%   $	 100��64    6@   �� *price+$ PropertyChanged=�5#      5&      �� 5'   
   $
��Left=�6   $��45��6-   $��	75,10,0,0q�69    �� TextWrapping$
 Wrap=�6L   $	��Top=�6�   $	��360��6�   ��6a   �� *PatientSearch+$ PropertyChanged=�6�   �� 5(   
   $
��Left=�6   $��45��6-   $��
75,145,0,0q�69   $
 Wrap=�6M   $	��Top=�6   $	��360��6�   ��6a   �� *DoctorSearch+6�   (  "System.Windows.Controls.DatePicker  5)   
   $
��Left=�6   $��
515,60,0,0q�60   $	��Top=�6k   $��25��6�   $	��165��6�      SelectedDate 6D   �� *SelectedDate+6�   �� 5*   
   $
��Save��6   $
��Left=�69   $��605,340,0,0q�6T   $	��Top=�6i   $��75��6�   $��65��6�   ��6    �� *Save+6�   �� 5+   
   $
��Left=�6   $��23��6-   $��515,197,0,0q�69   $
 Wrap=�6N   $	��Top=�6|   $	��120��6�   ��6b   �� *
Duration+6�   �� 5,   
   $��Duration��6   $
��Left=�6#   $��515,145,0,0q�6>   $	��Top=�6S   $��25��6k   $	��120��6w   5.      5/      