   M S B A M L   `   `   `  ����P  LProjectManagement_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:ProjectManagement_WPF.MenuMember ProjectManagement_WPF.MenuMember  5      7    1ProjectManagement_WPF.MenuMember.ProjectDashboard   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:ProjectManagement_WPF.MenuMember     5      .��5	      �� 
�������.+�5
   
   ��   �� Orientation$  
Horizontal=�6   $	��Top=�6.   $
��10 0q�6F   .+�5      �� $��Project��6   $
��Left=�6&   $��Center=�6A   $��22(�6\   $��15q�6j   �� 5      $
��Edit��6   $	��100��6$   $��35��60   $��	682,5,0,0q�6<   5      �� 5   
   $��Center=�6   $  
Horizontal=�63   $	��100��6L   $��10,4,0,0q�6Y   $	��Top=�6k   $	��742��6�   .+�5      � .+�5      �� ���#19BD9B$��58��6+   $��10,21,10,21q�67   $	��225��6L   �� 5      $����D:\Farin\Kerjaaan bootcamp\Kerjaan punya Yosan\Tugas Program\start learn mvs\ProjectManagement\ProjectManagement\ProjectManagement_WPF\ProjectManagement_WPF\Image\task2.png��6   $
��Left=�6�   $��50��6�   $��50��6�   $��Center=�6   $��
10,25,0,25q�6  �� 5      -   5         ��Name$ txt_ProjectValue��5      
�������$��Center=�6G   $��30��6d   $��197,20,10,0q�6p    �� TextWrapping$
 Wrap=�6�   $��15��6�   $	��Top=�6�   $��38��6�   $
��Bold"�6�   $��16(�6�   �� 5      -   5        $ txt_TotalProject��5      
�������$��Center=�6G   $��40��6d   $��127,39,10,0q�6p   $
 Wrap=�6�   $��Total Project��6�   $	��Top=�6�   $	��108��6�   $
��Bold"�6�   $��16(�6�   5      � 5      .+�5      �� ���#2B77E5$��58��6+   $��
20,21,0,21q�67   $	��225��6K   �� 5      $����D:\Farin\Kerjaaan bootcamp\Kerjaan punya Yosan\Tugas Program\start learn mvs\ProjectManagement\ProjectManagement\ProjectManagement_WPF\ProjectManagement_WPF\Image\checklist4.png��6   $
��Left=�6�   $��50��6�   $��50��6�   $��Center=�6  $��
20,25,0,25q�6   �� 5      -   5        $ txt_Task��5      
�������$��Center=�6?   $��30��6\   $��197,19,10,0q�6h   $
 Wrap=�6}   $��12��6�   $	��Top=�6�   $��38��6�   $
��Bold"�6�   $��16(�6�   �� 5      -   5        $ txt_detailTask��5      
�������$��Center=�6E   $��40��6b   $��
113,39,0,0q�6n   $
 Wrap=�6�   $��Completed Task��6�   $	��Top=�6�   $	��132��6�   $
��Bold"�6�   $��16(�6�   5      � 5      .+�5      �� ���#DE6667$��58��6+   $��
30,21,0,21q�67   $	��225��6K   �� 5      $����D:\Farin\Kerjaaan bootcamp\Kerjaan punya Yosan\Tugas Program\start learn mvs\ProjectManagement\ProjectManagement\ProjectManagement_WPF\ProjectManagement_WPF\Image\timer.png��6   $
��Left=�6�   $��50��6�   $��50��6�   $��Center=�6   $��
30,25,0,25q�6  �� 5      -   5        $ txt_Deadline��5      
�������$��Center=�6C   $��33��6`   $��
217,21,0,0q�6l   $
 Wrap=�6�   $��0��6�   $	��Top=�6�   $��38��6�   $
��Bold"�6�   $��16(�6�   �� 5      -   5        $ txt_OverdueTask��5      
�������$��Center=�6F   $��40��6c   $��
123,39,0,0q�6o   $
 Wrap=�6�   $��Overdue Tasks��6�   $	��Top=�6�   $	��132��6�   $
��Bold"�6�   $��16(�6�   5       5!      &   System.Windows.Controls.DataGrid  5"   
   -   5          Name$ Grid_Project��5"      $��Stretch=�6)   $��83��6H   $	��502��6U      Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Header$ Project Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *ProjectName+  5%      $ 
Start Date��6%    69   �� *	StartDate+  5&      $ Due Date��6%    67   �� *	DueDate+  5'      $ Detail Project��6%    6=   �� *DetailProject+  5(      $ Status��6%    65   �� *Status+  5)      $ Action��6%    65   �� *Action+5+      5,      5-      