using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.Platform.Windows;

namespace Shape3D_
{
    public partial class Form1 : Form
    {



        float xRotAngle = 45.0f, yRotAngle, zRotAngle = 0.0f;
        public Form1()
        {
            InitializeComponent();
            openGlControlBckgrnd.InitializeContexts();

            int width = openGlControlBckgrnd.Width;
            int height = openGlControlBckgrnd.Height;

            // Firstly, the window may have been resized so re-create the viewing area
            Gl.glViewport(0, 0, width, height);
            //arkaplan rengini olusturuyoruz.
            Gl.glClearColor(0.01f, 0.0f, 0.1f, 0.01f); // parametre degerleri 0.0-1.0 arasinda olmalidir.
            Gl.glClearDepth(1.0f);
            Gl.glEnable(Gl.GL_DEPTH_TEST);

            //glDepthFunc fonksiyonu ile derinlik testinde kullanılacak fonksiyonu belirtiyoruz. 
            //Burada parametre olarak geçilen GL_LEQUAL sembolik sabitinin belirttiği derinlik testi fonksiyonu, 
            //o an gelen z değeri, tamponda saklanan z değerine eşit ise veya ondan daha küçükse başarılı olur. 
            Gl.glDepthFunc(Gl.GL_LEQUAL);

            /**   glHint(GL_PERSPECTIVE_CORRECTION_HINT,GL_NICEST); 
            glHint fonksiyonu, perspektif ayarlamalarını yapar. Burada parametre olarak geçilen değerler ile en iyi
            perspektifin sağlanması isteği iletilmiştir. Bu fonksiyon performans düşüklüğüne neden olabilir, 
            ancak görünüşü daha iyi hale getirir. */

            // The second step is to add a projection matrix.  
            // glMatrixMode(GL_PROJECTION); Tell OpenGL to manipulate the correct matrix stack
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            //glLoadIdentity(); // Reset the projection matrix, or bad things happen after multiple calls to 
            //below functions!
            Gl.glLoadIdentity();

            // gluPerspective( ... ) // Uncomment to use (easy) 3D rendering
            Glu.gluPerspective(45.0f, (double)width / (double)height, 0.01f, 5000.0f);
        }

        private void openGlControlBckgrnd_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            Gl.glTranslated(-1.5f, 0.0f, -6.0f);
            Gl.glRotated(xRotAngle, 0.0f, 1.0f, 0.0f);

            Gl.glBegin(Gl.GL_TRIANGLES);

            Gl.glColor3f(1.0f, 0.0f, 0.0f); // red - green - blue.
            Gl.glVertex3f(2.0f, 1.0f, 0.0f);

            Gl.glColor3f(0.5f, 0.2f, 0.0f); // red - green - blue.
            Gl.glVertex3f(1.0f, -1.0f, 1.0f);


            Gl.glColor3f(0.2f, 0.5f, 0.0f); // red - green - blue.
            Gl.glVertex3f(3.0f, -1.0f, 1.0f);

            Gl.glColor3f(0.0f, 0.5f, 0.2f); // red - green - blue.
            Gl.glVertex3f(2.0f, 1.0f, 0.0f);

            Gl.glColor3f(0.8f, 0.0f, 0.7f); // red - green - blue.
            Gl.glVertex3f(3.0f, -1.0f, 1.0f);

            Gl.glColor3f(0.0f, 0.5f, 0.4f); // red - green - blue.
            Gl.glVertex3f(3.0f, -1.0f, -1.0f);

            Gl.glColor3f(0.4f, 0.5f, 0.3f); // red - green - blue.
            Gl.glVertex3f(2.0f, 1.0f, 0.0f);

            Gl.glColor3f(0.6f, 0.0f, 0.0f); // red - green - blue.
            Gl.glVertex3f(3.0f, -1.0f, -1.0f);

            Gl.glColor3f(0.3f, 0.0f, 0.2f); // red - green - blue.
            Gl.glVertex3f(1.0f, -1.0f, -1.0f);

            Gl.glColor3f(0.0f, 0.0f, 0.8f); // red - green - blue.
            Gl.glVertex3f(2.0f, 1.0f, 0.0f);

            Gl.glColor3f(0.4f, 0.0f, 0.1f); // red - green - blue.
            Gl.glVertex3f(1.0f, -1.0f, -1.0f);

            Gl.glColor3f(0.0f, 0.5f, 1.0f); // red - green - blue.
            Gl.glVertex3f(1.0f, -1.0f, 1.0f);

            Gl.glEnd();

            //glRotated - glRotatef: I think its only now that cards are starting to support doubles 
            //as well as floats 

            //  Gl.glTranslated(0,0,-4);
            // Gl.glRotated(xRot += 0.5, 1,0,0); // Rotate on x
            //Gl.glRotated(yRot += 0.5, 0, 1, 0); // Rotate on y
            //Gl.glRotated(zRot += 0.5, 0, 0, 1); // Rotate on z


            //  Gl.glBegin(Gl.GL_QUADS); // dortgen cizecegiz.




        }


    }

}
/* glMatrixMode — specify which matrix is the current matrix , glMatrixMode(	GLenum mode);

mode :
Specifies which matrix stack is the target for subsequent matrix operations. 
Three values are accepted: GL_MODELVIEW, GL_PROJECTION, and GL_TEXTURE. The initial value is GL_MODELVIEW.
*/

/*glTranslate — multiply the current matrix by a translation matrix.
x, y, z : Specify the x, y, and z coordinates of a translation vector.*/


//  http://stackoverflow.com/questions/13053334/gluperspective-glviewport-glulookat-and-the-gl-projection-and-gl-modelview-mat

/*glViewPort is in screen pixel units: that's it, it has nothing to do with the 3D world "inside" 
your graphics card. It just tells wich part of the window will be used for rendering 
(or just will be visible).
glOrtho instead changes the "inner" world and is OpenGL units:
More OpenGL units will fit into the visible part of the screen, 
so "bigger" objects will fit easily into viewable area if you increase the ortho size. */

