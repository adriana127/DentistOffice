   M S B A M L   `   `   `  ����O  KCabinet Stomatologic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Cabinet_Stomatologic.ViewCabinet_Stomatologic.View  5      +    %Cabinet_Stomatologic.View.PatientView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:Cabinet_Stomatologic.View     5      .��5	      � .+�5
   
   �� $
��Left=�6   $	��585��6,   $	��Top=�69   $
��1040��6Q   $��
0,0,0,-0.4q�6^   .+�5      �� 
�������$	��425��6y   
  �� Top$  50��6�   $
��1040��6�   ��6+   �� *PatientList+ �� SelectedItem 6O   �� *SelectedPatient+ �� View 5      �� 5      .P�5      �� $��Patient's Name��6)    �� Width$. (200                                     ��6A    �� DisplayMemberBinding 5   '   �� *
fullname+ �� UpdateSourceTrigger$ PropertyChanged=��� 5      $��Phone��6)   $	 200��68    6D   �� *personinformation.phone+$ PropertyChanged=��� 5      $��Doctor��6)   $	 200��69    6E   �� *doctor.fullname+$ PropertyChanged=�5      5      �� 5      $��Add Patient��6    �� Left$	 825��6R   $	  480��6d   $	��130��6u   $��60��6�   ��6+   �� *NavigatePersonForm+6�   �� 5      $��50��6   
���   �$
��1040��63   �� 5      
�������$��
Procedures��6U   $	��190��6j   $��50��6v   $	 571��6�   ��6(   �� *ChangeScreenToProcedures+6�   �� 5      
�������$��Accounts��6S   $	��190��6f   $��50��6r   $	 761��6~   ��6(   �� *ChangeScreenToAccounts+6~   �� 5      
�������$��Doctors��6Q   $	��190��6c   $��50��6o   ��6(   �� *ChangeScreenToDoctor+6o   �� 5      
�������$��Patients��6R   $	��190��6e   $��50��6q   $	 190��6}   ��6(   �� *ChangeScreenToPatient+6}   �� 5      
�������$��Appointments��6V   $	��190��6m   $��50��6y   $	 381��6�   ��6(   �� *ChangeScreenToAppointment+6�   5       5!      5"      