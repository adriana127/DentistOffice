   M S B A M L   `   `   `  ����O  KCabinet Stomatologic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Cabinet_StomatologicCabinet_Stomatologic  5      E'clr-namespace:Cabinet_Stomatologic.ViewCabinet_Stomatologic.View  5      Q-clr-namespace:Cabinet_Stomatologic.View_ModelCabinet_Stomatologic.View_Model  5          Cabinet_Stomatologic.App   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      4local"clr-namespace:Cabinet_Stomatologic     5      8view'clr-namespace:Cabinet_Stomatologic.View     5      C	viewmodel-clr-namespace:Cabinet_Stomatologic.View_Model     5        �� 	Resources  5	       �� DataType5   /Cabinet_Stomatologic.View_Model.DoctorViewModel+   %Cabinet_Stomatologic.View.DoctorsView6  0Cabinet_Stomatologic.View_Model.PatientViewModel+   %Cabinet_Stomatologic.View.PatientView9   3Cabinet_Stomatologic.View_Model.FornPersonViewModel.   (Cabinet_Stomatologic.View.FormPersonView4  .Cabinet_Stomatologic.View_Model.LogInViewModel)   #Cabinet_Stomatologic.View.LogInView5	  /Cabinet_Stomatologic.View_Model.SignUpViewModel*
   $Cabinet_Stomatologic.View.SignUpView@  :Cabinet_Stomatologic.View_Model.PersonInformationViewModel5   /Cabinet_Stomatologic.View.PersonInfromationView=  7Cabinet_Stomatologic.View_Model.AddAppointmentViewModel2   ,Cabinet_Stomatologic.View.AddAppointmentView:  4Cabinet_Stomatologic.View_Model.AppointemtsViewModel0   *Cabinet_Stomatologic.View.AppointmentsView8  2Cabinet_Stomatologic.View_Model.ProcedureViewModel-   'Cabinet_Stomatologic.View.ProcedureView:   4Cabinet_Stomatologic.View_Model.FormAccountViewModel/   )Cabinet_Stomatologic.View.FormAccountView7   1Cabinet_Stomatologic.View_Model.AccountsViewModel,   &Cabinet_Stomatologic.View.AccountsView   listDoctorTemplate  listBoxTemplate � RowDefinitions � ColumnDefinitions  listPatientTemplate��%�	  (��       5
      *, +)(�� ;     5      *, +)(�� v     5      *, +)(�� �     5      *, +)(�� �     5      *,	 +)(�� '    5"      *, +)(�� b    5'      *, +)(�� �    5+      *, +)(�� �    5/      *, +)(��     54      *, +)(�� N    59      *, +)&	  �    &	     &	 �    �� 5
   
   "  6   .R�5        5      5      �� 5   
   "  6   .R�5        5      5      �� 5   
   "  6   .R�5        5      5      �� 5   
   "  6   .R�5        5      5      �� 5   
   " 	 6   .R�5      
  5      5       �� 5"   
   "  6   .R�5#        5$      5%      �� 5'   
   "  6   .R�5(        5)      5*      �� 5+   
   "  6   .R�5,        5-      5.      �� 5/   
   "  6   .R�50        51      52      �� 54   
   "  6   .R�55        56      57      �� 59   
   "  6   .R�5:        5;      5<      �� 5>   
   .R�5?      � .+�5@      �� 
��� � �$
��Bold"�6I   ��6   �� *
fullname+6I   5A      5B      �� 5C   
   .R�5D      � 
������� 5E      �� 5F      $��* �6$   $	��180��6/   �� 5G      $��40 �6%   $��25��61   .+�5I      � $��0��6    5J      �� 5K      $��25 �6+   $��25��66   �� 5L      $	��200 �6,   $��25��68   �� 5M      .+�5P      �� $��1��6   $��Center=�6,   $	��200��6I   $	��200��6V   $+��%C:\Users\Adriana\Downloads\doctor.jpg��6c   6�   5R      �� 5S      $��1��6   .+�5T      ]� .+�5U      ]� .+�5V      �� $
��Bold"�6$   $��
     Name:��66   
���   �$
��Left=�6[   $��5,0,10,0q�6q   �� 5W      $�� ��6$   �� 5X      
���   ���6(   �� *
fullname+6B   �� 5Y      $�� ��6(   
���   �61   5[      ]� 5]      .+�5^      �� $
��Bold"�6$   $��     Phone Number:��66   
���   �$
��Left=�6c   $��5,0,5,0q�6y   �� 5_      
���   ���6$   �� *personinformation.phone+6M   5`      5a      5c      5d      5e      �� 5i   
   .R�5j      �  5k      �� 5l      $	��200 �6'   $��25��63   �� 5m      $	��200 �6'   $��25��63   �� 5n      $	��200 �6'   $��25��63   �� 5q      .+�5s      �� $��0��6   
��� � �$
��Bold"�6Y   ��6,   �� *
fullname+6Y   �� 5t      $��1��6   
��� � �$
��Bold"�6h   ��6,   �� *personinformation.phone+6h   �� 5u      $��2��6   
��� � �$
��Bold"�6`   ��6,   �� *doctor.fullname+6`   5w      5x      5y      5z      