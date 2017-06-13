namespace ArbolBinario
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtExpresion = new System.Windows.Forms.TextBox();
            this.txtPreOrder = new System.Windows.Forms.TextBox();
            this.txtPostOrder = new System.Windows.Forms.TextBox();
            this.txtResolver = new System.Windows.Forms.TextBox();
            this.btnPreOrder = new System.Windows.Forms.Button();
            this.btnPostOrder = new System.Windows.Forms.Button();
            this.btnResolverPost = new System.Windows.Forms.Button();
            this.btnResolverPre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(174, 9);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtExpresion
            // 
            this.txtExpresion.Location = new System.Drawing.Point(12, 12);
            this.txtExpresion.Name = "txtExpresion";
            this.txtExpresion.Size = new System.Drawing.Size(156, 20);
            this.txtExpresion.TabIndex = 1;
            // 
            // txtPreOrder
            // 
            this.txtPreOrder.Location = new System.Drawing.Point(93, 67);
            this.txtPreOrder.Name = "txtPreOrder";
            this.txtPreOrder.Size = new System.Drawing.Size(160, 20);
            this.txtPreOrder.TabIndex = 2;
            // 
            // txtPostOrder
            // 
            this.txtPostOrder.Location = new System.Drawing.Point(93, 96);
            this.txtPostOrder.Name = "txtPostOrder";
            this.txtPostOrder.Size = new System.Drawing.Size(160, 20);
            this.txtPostOrder.TabIndex = 7;
            // 
            // txtResolver
            // 
            this.txtResolver.Location = new System.Drawing.Point(93, 151);
            this.txtResolver.Name = "txtResolver";
            this.txtResolver.Size = new System.Drawing.Size(160, 20);
            this.txtResolver.TabIndex = 8;
            // 
            // btnPreOrder
            // 
            this.btnPreOrder.Location = new System.Drawing.Point(12, 65);
            this.btnPreOrder.Name = "btnPreOrder";
            this.btnPreOrder.Size = new System.Drawing.Size(75, 23);
            this.btnPreOrder.TabIndex = 9;
            this.btnPreOrder.Text = "PreOrder";
            this.btnPreOrder.UseVisualStyleBackColor = true;
            this.btnPreOrder.Click += new System.EventHandler(this.btnPreOrder_Click);
            // 
            // btnPostOrder
            // 
            this.btnPostOrder.Location = new System.Drawing.Point(12, 94);
            this.btnPostOrder.Name = "btnPostOrder";
            this.btnPostOrder.Size = new System.Drawing.Size(75, 23);
            this.btnPostOrder.TabIndex = 10;
            this.btnPostOrder.Text = "PostOrder";
            this.btnPostOrder.UseVisualStyleBackColor = true;
            this.btnPostOrder.Click += new System.EventHandler(this.btnPostOrder_Click);
            // 
            // btnResolverPost
            // 
            this.btnResolverPost.Location = new System.Drawing.Point(259, 94);
            this.btnResolverPost.Name = "btnResolverPost";
            this.btnResolverPost.Size = new System.Drawing.Size(75, 23);
            this.btnResolverPost.TabIndex = 11;
            this.btnResolverPost.Text = "Resolver";
            this.btnResolverPost.UseVisualStyleBackColor = true;
            this.btnResolverPost.Click += new System.EventHandler(this.btnResolverPost_Click);
            // 
            // btnResolverPre
            // 
            this.btnResolverPre.Location = new System.Drawing.Point(259, 65);
            this.btnResolverPre.Name = "btnResolverPre";
            this.btnResolverPre.Size = new System.Drawing.Size(75, 23);
            this.btnResolverPre.TabIndex = 12;
            this.btnResolverPre.Text = "Resolver";
            this.btnResolverPre.UseVisualStyleBackColor = true;
            this.btnResolverPre.Click += new System.EventHandler(this.btnResolverPre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 198);
            this.Controls.Add(this.btnResolverPre);
            this.Controls.Add(this.btnResolverPost);
            this.Controls.Add(this.btnPostOrder);
            this.Controls.Add(this.btnPreOrder);
            this.Controls.Add(this.txtResolver);
            this.Controls.Add(this.txtPostOrder);
            this.Controls.Add(this.txtPreOrder);
            this.Controls.Add(this.txtExpresion);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtExpresion;
        private System.Windows.Forms.TextBox txtPreOrder;
        private System.Windows.Forms.TextBox txtPostOrder;
        private System.Windows.Forms.TextBox txtResolver;
        private System.Windows.Forms.Button btnPreOrder;
        private System.Windows.Forms.Button btnPostOrder;
        private System.Windows.Forms.Button btnResolverPost;
        private System.Windows.Forms.Button btnResolverPre;
    }
}

