   M S B A M L   `   `   `  ����O  KCabinet Stomatologic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Cabinet_Stomatologic.ViewCabinet_Stomatologic.View  5      5    /Cabinet_Stomatologic.View.PersonInfromationView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:Cabinet_Stomatologic.View     5      .��5	      � .+�5
   
   �� $
��Left=�6   $	��585��6,   $	��Top=�69   $
��1040��6Q   $��
0,0,0,-0.4q�6^   .+�5      �� $��50��6   
���   �$
��1040��63   �� 5      
�������$��
Procedures��6U   $	��190��6j   $��50��6v     �� Left$	  571��6�   ��6(   �� *ChangeScreenToProcedures+6�   �� 5      
�������$��Accounts��6S   $	��190��6f   $��50��6r   $	  761��6~   ��6(   �� *ChangeScreenToAccounts+6~   �� 5      
�������$��Doctors��6Q   $	��190��6c   $��50��6o   ��6(   �� *ChangeScreenToDoctor+6o   �� 5      
�������$��Patients��6R   $	��190��6e   $��50��6q   $	  190��6}   ��6(   �� *ChangeScreenToPatient+6}   �� 5      
�������$��Appointments��6V   $	��190��6m   $��50��6y   $	  381��6�   ��6(   �� *ChangeScreenToAppointment+6�   �� 5      $��Modify Doctor��6   $	  850��6R   
 �� Top$	 480��6d   $	��130��6u   $��60��6�   ��6-   �� *ModifyPersonForm+6�   �� 5      $��Delete Doctor��6   $	  660��6N   $	 480��6`   $	��130��6q   $��60��6}   ��6-   �� *RemovePerson+6}   �� 5      $	��215��6   $+��%C:\Users\Adriana\Downloads\doctor.jpg��6!   $  65��6P   $ 70��6a   $	��265��6q   �� 5      $  65��63   $	 290��6D   $	��445��6U   $��40��6a   $��20(�6m   $
��Bold"�6{   ��6   �� *
PersonName+6{   �� 5      $��Email��6   $  79��6$   $	 350��65   $	��265��6F   $��40��6R   $��16(�6^   �� 5      $��Phone��6   $  79��6$   $	 395��65   $	��265��6F   $��40��6R   $��16(�6^   �� 5      $
��Left=�64   $	  160��6O   $	 355��6a   $	��265��6r   $��40��6~   $��16(�6�   ��6   �� *PersonEmail+6�   �� 5      $
��Left=�64   $	  160��6O   $	 395��6a   $	��265��6r   $��40��6~   $��16(�6�   ��6   �� *PersonPhone+6�   �� 5      $��Salary for current month��6   $  79��67   $	 435��6H   $	��265��6Y   $��40��6e   $��16(�6q   �� 5      $
��Left=�66   $	  270��6Q   $	 435��6c   $	��265��6t   $��40��6�   $��16(�6�   ��6   �� *MonthlySalary+6�   5      �� 5    
   $
��Left=�6   $	��240��6Y   $��720,95,-185,0q�6f   $	��Top=�6}   $	��265��6�   ��6.   �� *DoctorPatientsList+ �� View 5!      �� 5"      .P�5#      �� $��Patient��6%    �� Width$W Q150                                                                              ��66    �� DisplayMemberBinding 5%   '   �� *Patient.fullname+ �� UpdateSourceTrigger$ PropertyChanged=��� 5&      $��Patient��6%   $W Q150                                                                              ��66    5(   '   �� *NumberOfProcedures+$ PropertyChanged=�5*      5,      5-      5.      