
namespace DatabaseClient
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonReferences = new System.Windows.Forms.Button();
            this.buttonApplications = new System.Windows.Forms.Button();
            this.buttonCourses = new System.Windows.Forms.Button();
            this.buttonDrivingSchools = new System.Windows.Forms.Button();
            this.buttonCars = new System.Windows.Forms.Button();
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.buttonOffices = new System.Windows.Forms.Button();
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonLessons = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelLogo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.panelLogo.Controls.Add(this.labelLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(205, 65);
            this.panelLogo.TabIndex = 0;
            // 
            // labelLogo
            // 
            this.labelLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogo.ForeColor = System.Drawing.Color.White;
            this.labelLogo.Location = new System.Drawing.Point(6, 23);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(195, 19);
            this.labelLogo.TabIndex = 1;
            this.labelLogo.Text = "ПИ-21б Бубнов Георгий";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.panelMenu.Controls.Add(this.buttonReferences);
            this.panelMenu.Controls.Add(this.buttonApplications);
            this.panelMenu.Controls.Add(this.buttonCourses);
            this.panelMenu.Controls.Add(this.buttonDrivingSchools);
            this.panelMenu.Controls.Add(this.buttonCars);
            this.panelMenu.Controls.Add(this.buttonEmployees);
            this.panelMenu.Controls.Add(this.buttonOffices);
            this.panelMenu.Controls.Add(this.buttonStudents);
            this.panelMenu.Controls.Add(this.buttonLessons);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.Black;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(205, 701);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonReferences
            // 
            this.buttonReferences.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReferences.FlatAppearance.BorderSize = 0;
            this.buttonReferences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReferences.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonReferences.Image = global::DatabaseClient.Properties.Resources.references;
            this.buttonReferences.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReferences.Location = new System.Drawing.Point(0, 625);
            this.buttonReferences.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReferences.Name = "buttonReferences";
            this.buttonReferences.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonReferences.Size = new System.Drawing.Size(205, 70);
            this.buttonReferences.TabIndex = 9;
            this.buttonReferences.Text = "  Справочники";
            this.buttonReferences.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReferences.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReferences.UseVisualStyleBackColor = true;
            this.buttonReferences.Click += new System.EventHandler(this.buttonReferences_Click);
            // 
            // buttonApplications
            // 
            this.buttonApplications.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonApplications.FlatAppearance.BorderSize = 0;
            this.buttonApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApplications.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonApplications.Image = global::DatabaseClient.Properties.Resources.applications1;
            this.buttonApplications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonApplications.Location = new System.Drawing.Point(0, 555);
            this.buttonApplications.Margin = new System.Windows.Forms.Padding(2);
            this.buttonApplications.Name = "buttonApplications";
            this.buttonApplications.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonApplications.Size = new System.Drawing.Size(205, 70);
            this.buttonApplications.TabIndex = 8;
            this.buttonApplications.Text = "  Заявки";
            this.buttonApplications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonApplications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonApplications.UseVisualStyleBackColor = true;
            this.buttonApplications.Click += new System.EventHandler(this.buttonApplications_Click);
            // 
            // buttonCourses
            // 
            this.buttonCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCourses.FlatAppearance.BorderSize = 0;
            this.buttonCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCourses.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonCourses.Image = global::DatabaseClient.Properties.Resources.сourses;
            this.buttonCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCourses.Location = new System.Drawing.Point(0, 485);
            this.buttonCourses.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCourses.Name = "buttonCourses";
            this.buttonCourses.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonCourses.Size = new System.Drawing.Size(205, 70);
            this.buttonCourses.TabIndex = 7;
            this.buttonCourses.Text = "  Курсы";
            this.buttonCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCourses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCourses.UseVisualStyleBackColor = true;
            this.buttonCourses.Click += new System.EventHandler(this.buttonCourses_Click);
            // 
            // buttonDrivingSchools
            // 
            this.buttonDrivingSchools.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDrivingSchools.FlatAppearance.BorderSize = 0;
            this.buttonDrivingSchools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDrivingSchools.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonDrivingSchools.Image = global::DatabaseClient.Properties.Resources.driving_schools;
            this.buttonDrivingSchools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDrivingSchools.Location = new System.Drawing.Point(0, 415);
            this.buttonDrivingSchools.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDrivingSchools.Name = "buttonDrivingSchools";
            this.buttonDrivingSchools.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonDrivingSchools.Size = new System.Drawing.Size(205, 70);
            this.buttonDrivingSchools.TabIndex = 6;
            this.buttonDrivingSchools.Text = "  Автошколы";
            this.buttonDrivingSchools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDrivingSchools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDrivingSchools.UseVisualStyleBackColor = true;
            this.buttonDrivingSchools.Click += new System.EventHandler(this.buttonDrivingSchools_Click);
            // 
            // buttonCars
            // 
            this.buttonCars.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCars.FlatAppearance.BorderSize = 0;
            this.buttonCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCars.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonCars.Image = global::DatabaseClient.Properties.Resources.cars;
            this.buttonCars.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCars.Location = new System.Drawing.Point(0, 345);
            this.buttonCars.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCars.Name = "buttonCars";
            this.buttonCars.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonCars.Size = new System.Drawing.Size(205, 70);
            this.buttonCars.TabIndex = 5;
            this.buttonCars.Text = "  Автомобили";
            this.buttonCars.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCars.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCars.UseVisualStyleBackColor = true;
            this.buttonCars.Click += new System.EventHandler(this.buttonCars_Click);
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEmployees.FlatAppearance.BorderSize = 0;
            this.buttonEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployees.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonEmployees.Image = global::DatabaseClient.Properties.Resources.employees;
            this.buttonEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmployees.Location = new System.Drawing.Point(0, 275);
            this.buttonEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonEmployees.Size = new System.Drawing.Size(205, 70);
            this.buttonEmployees.TabIndex = 4;
            this.buttonEmployees.Text = "  Сотрудники";
            this.buttonEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEmployees.UseVisualStyleBackColor = true;
            this.buttonEmployees.Click += new System.EventHandler(this.buttonEmployees_Click);
            // 
            // buttonOffices
            // 
            this.buttonOffices.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOffices.FlatAppearance.BorderSize = 0;
            this.buttonOffices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOffices.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonOffices.Image = global::DatabaseClient.Properties.Resources.offices;
            this.buttonOffices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOffices.Location = new System.Drawing.Point(0, 205);
            this.buttonOffices.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOffices.Name = "buttonOffices";
            this.buttonOffices.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonOffices.Size = new System.Drawing.Size(205, 70);
            this.buttonOffices.TabIndex = 3;
            this.buttonOffices.Text = "  Офисы";
            this.buttonOffices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOffices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOffices.UseVisualStyleBackColor = true;
            this.buttonOffices.Click += new System.EventHandler(this.buttonOffices_Click);
            // 
            // buttonStudents
            // 
            this.buttonStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStudents.FlatAppearance.BorderSize = 0;
            this.buttonStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudents.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonStudents.Image = global::DatabaseClient.Properties.Resources.students;
            this.buttonStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudents.Location = new System.Drawing.Point(0, 135);
            this.buttonStudents.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonStudents.Size = new System.Drawing.Size(205, 70);
            this.buttonStudents.TabIndex = 2;
            this.buttonStudents.Text = "  Обучающиеся";
            this.buttonStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStudents.Click += new System.EventHandler(this.buttonStudents_Click);
            // 
            // buttonLessons
            // 
            this.buttonLessons.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLessons.FlatAppearance.BorderSize = 0;
            this.buttonLessons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLessons.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonLessons.ForeColor = System.Drawing.Color.Black;
            this.buttonLessons.Image = global::DatabaseClient.Properties.Resources.lesson;
            this.buttonLessons.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLessons.Location = new System.Drawing.Point(0, 65);
            this.buttonLessons.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLessons.Name = "buttonLessons";
            this.buttonLessons.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonLessons.Size = new System.Drawing.Size(205, 70);
            this.buttonLessons.TabIndex = 1;
            this.buttonLessons.Text = "  Занятия";
            this.buttonLessons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLessons.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLessons.UseVisualStyleBackColor = true;
            this.buttonLessons.Click += new System.EventHandler(this.buttonLessons_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(75)))), ((int)(((byte)(65)))));
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(205, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(789, 65);
            this.panelTitleBar.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(789, 65);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Курсовой проект";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(205, 65);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(789, 636);
            this.panelDesktop.TabIndex = 2;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 701);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1010, 740);
            this.Name = "FormMainMenu";
            this.Text = "Автоматизация учета деятельности автошкол города";
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonLessons;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonOffices;
        private System.Windows.Forms.Button buttonEmployees;
        private System.Windows.Forms.Button buttonCars;
        private System.Windows.Forms.Button buttonDrivingSchools;
        private System.Windows.Forms.Button buttonCourses;
        private System.Windows.Forms.Button buttonReferences;
        private System.Windows.Forms.Button buttonApplications;
        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

