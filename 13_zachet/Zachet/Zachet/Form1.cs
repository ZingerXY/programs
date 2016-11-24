using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zachet
{
    public partial class Form1 : Form
    {
        int m, n, f = 0;
        int c;
        Random rand = new Random();
        string[] names = new string[] { "Abbott", "Acevedo", "Acosta", "Adams", "Adkins", "Aguilar", "Aguirre", "Albert", "Alexander", "Alford", "Allen", "Allison", "Alston", "Alvarado", "Alvarez", "Anderson", "Andrews", "Anthony", "Armstrong", "Arnold", "Ashley", "Atkins", "Atkinson", "Austin", "Avery", "Avila", "Ayala", "Ayers", "Bailey", "Baird", "Baker", "Baldwin", "Ball", "Ballard", "Banks", "Barber", "Barker", "Barlow", "Barnes", "Barnett", "Barr", "Barrera", "Barrett", "Barron", "Barry", "Bartlett", "Barton", "Bass", "Bates", "Battle", "Bauer", "Baxter", "Beach", "Bean", "Beard", "Beasley", "Beck", "Becker", "Bell", "Bender", "Benjamin", "Bennett", "Benson", "Bentley", "Benton", "Berg", "Berger", "Bernard", "Berry", "Best", "Bird", "Bishop", "Black", "Blackburn", "Blackwell", "Blair", "Blake", "Blanchard", "Blankenship", "Blevins", "Bolton", "Bond", "Bonner", "Booker", "Boone", "Booth", "Bowen", "Bowers", "Bowman", "Boyd", "Boyer", "Boyle", "Bradford", "Bradley", "Bradshaw", "Brady", "Branch", "Bray", "Brennan", "Brewer", "Bridges", "Briggs", "Bright", "Britt", "Brock", "Brooks", "Brown", "Browning", "Bruce", "Bryan", "Bryant", "Buchanan", "Buck", "Buckley", "Buckner", "Bullock", "Burch", "Burgess", "Burke", "Burks", "Burnett", "Burns", "Burris", "Burt", "Burton", "Bush", "Butler", "Byers", "Byrd", "Cabrera", "Cain", "Calderon", "Caldwell", "Calhoun", "Callahan", "Camacho", "Cameron", "Campbell", "Campos", "Cannon", "Cantrell", "Cantu", "Cardenas", "Carey", "Carlson", "Carney", "Carpenter", "Carr", "Carrillo", "Carroll", "Carson", "Carter", "Carver", "Case", "Casey", "Cash", "Castaneda", "Castillo", "Castro", "Cervantes", "Chambers", "Chan", "Chandler", "Chaney", "Chang", "Chapman", "Charles", "Chase", "Chavez", "Chen", "Cherry", "Christensen", "Christian", "Church", "Clark", "Clarke", "Clay", "Clayton", "Clements", "Clemons", "Cleveland", "Cline", "Cobb", "Cochran", "Coffey", "Cohen", "Cole", "Coleman", "Collier", "Collins", "Colon", "Combs", "Compton", "Conley", "Conner", "Conrad", "Contreras", "Conway", "Cook", "Cooke", "Cooley", "Cooper", "Copeland", "Cortez", "Cote", "Cotton", "Cox", "Craft", "Craig", "Crane", "Crawford", "Crosby", "Cross", "Cruz", "Cummings", "Cunningham", "Curry", "Curtis", "Dale", "Dalton", "Daniel", "Daniels", "Daugherty", "Davenport", "David", "Davidson", "Davis", "Dawson", "Day", "Dean", "Decker", "Dejesus", "Delacruz", "Delaney", "Deleon", "Delgado", "Dennis", "Diaz", "Dickerson", "Dickson", "Dillard", "Dillon", "Dixon", "Dodson", "Dominguez", "Donaldson", "Donovan", "Dorsey", "Dotson", "Douglas", "Downs", "Doyle", "Drake", "Dudley", "Duffy", "Duke", "Duncan", "Dunlap", "Dunn", "Duran", "Durham", "Dyer", "Eaton", "Edwards", "Elliott", "Ellis", "Ellison", "Emerson", "England", "English", "Erickson", "Espinoza", "Estes", "Estrada", "Evans", "Everett", "Ewing", "Farley", "Farmer", "Farrell", "Faulkner", "Ferguson", "Fernandez", "Ferrell", "Fields", "Figueroa", "Finch", "Finley", "Fischer", "Fisher", "Fitzgerald", "Fitzpatrick", "Fleming", "Fletcher", "Flores", "Flowers", "Floyd", "Flynn", "Foley", "Forbes", "Ford", "Foreman", "Foster", "Fowler", "Fox", "Francis", "Franco", "Frank", "Franklin", "Franks", "Frazier", "Frederick", "Freeman", "French", "Frost", "Fry", "Frye", "Fuentes", "Fuller", "Fulton", "Gaines", "Gallagher", "Gallegos", "Galloway", "Gamble", "Garcia", "Gardner", "Garner", "Garrett", "Garrison", "Garza", "Gates", "Gay", "Gentry", "George", "Gibbs", "Gibson", "Gilbert", "Giles", "Gill", "Gillespie", "Gilliam", "Gilmore", "Glass", "Glenn", "Glover", "Goff", "Golden", "Gomez", "Gonzales", "Gonzalez", "Good", "Goodman", "Goodwin", "Gordon", "Gould", "Graham", "Grant", "Graves", "Gray", "Green", "Greene", "Greer", "Gregory", "Griffin", "Griffith", "Grimes", "Gross", "Guerra", "Guerrero", "Guthrie", "Gutierrez", "Guy", "Guzman", "Hahn", "Hale", "Haley", "Hall", "Hamilton", "Hammond", "Hampton", "Hancock", "Haney", "Hansen", "Hanson", "Hardin", "Harding", "Hardy", "Harmon", "Harper", "Harrell", "Harrington", "Harris", "Harrison", "Hart", "Hartman", "Harvey", "Hatfield", "Hawkins", "Hayden", "Hayes", "Haynes", "Hays", "Head", "Heath", "Hebert", "Henderson", "Hendricks", "Hendrix", "Henry", "Hensley", "Henson", "Herman", "Hernandez", "Herrera", "Herring", "Hess", "Hester", "Hewitt", "Hickman", "Hicks", "Higgins", "Hill", "Hines", "Hinton", "Hobbs", "Hodge", "Hodges", "Hoffman", "Hogan", "Holcomb", "Holden", "Holder", "Holland", "Holloway", "Holman", "Holmes", "Holt", "Hood", "Hooper", "Hoover", "Hopkins", "Hopper", "Horn", "Horne", "Horton", "House", "Houston", "Howard", "Howe", "Howell", "Hubbard", "Huber", "Hudson", "Huff", "Huffman", "Hughes", "Hull", "Humphrey", "Hunt", "Hunter", "Hurley", "Hurst", "Hutchinson", "Hyde", "Ingram", "Irwin", "Jackson", "Jacobs", "Jacobson", "James", "Jarvis", "Jefferson", "Jenkins", "Jennings", "Jensen", "Jimenez", "Johns", "Johnson", "Johnston", "Jones", "Jordan", "Joseph", "Joyce", "Joyner", "Juarez", "Justice", "Kane", "Kaufman", "Keith", "Keller", "Kelley", "Kelly", "Kemp", "Kennedy", "Kent", "Kerr", "Key", "Kidd", "Kim", "King", "Kinney", "Kirby", "Kirk", "Kirkland", "Klein", "Kline", "Knapp", "Knight", "Knowles", "Knox", "Koch", "Kramer", "Lamb", "Lambert", "Lancaster", "Landry", "Lane", "Lang", "Langley", "Lara", "Larsen", "Larson", "Lawrence", "Lawson", "Le", "Leach", "Leblanc", "Lee", "Leon", "Leonard", "Lester", "Levine", "Levy", "Lewis", "Lindsay", "Lindsey", "Little", "Livingston", "Lloyd", "Logan", "Long", "Lopez", "Lott", "Love", "Lowe", "Lowery", "Lucas", "Luna", "Lynch", "Lynn", "Lyons", "Macdonald", "Macias", "Mack", "Madden", "Maddox", "Maldonado", "Malone", "Mann", "Manning", "Marks", "Marquez", "Marsh", "Marshall", "Martin", "Martinez", "Mason", "Massey", "Mathews", "Mathis", "Matthews", "Maxwell", "May", "Mayer", "Maynard", "Mayo", "Mays", "Mcbride", "Mccall", "Mccarthy", "Mccarty", "Mcclain", "Mcclure", "Mcconnell", "Mccormick", "Mccoy", "Mccray", "Mccullough", "Mcdaniel", "Mcdonald", "Mcdowell", "Mcfadden", "Mcfarland", "Mcgee", "Mcgowan", "Mcguire", "Mcintosh", "Mcintyre", "Mckay", "Mckee", "Mckenzie", "Mckinney", "Mcknight", "Mclaughlin", "Mclean", "Mcleod", "Mcmahon", "Mcmillan", "Mcneil", "Mcpherson", "Meadows", "Medina", "Mejia", "Melendez", "Melton", "Mendez", "Mendoza", "Mercado", "Mercer", "Merrill", "Merritt", "Meyer", "Meyers", "Michael", "Middleton", "Miles", "Miller", "Mills", "Miranda", "Mitchell", "Molina", "Monroe", "Montgomery", "Montoya", "Moody", "Moon", "Mooney", "Moore", "Morales", "Moran", "Moreno", "Morgan", "Morin", "Morris", "Morrison", "Morrow", "Morse", "Morton", "Moses", "Mosley", "Moss", "Mueller", "Mullen", "Mullins", "Munoz", "Murphy", "Murray", "Myers", "Nash", "Navarro", "Neal", "Nelson", "Newman", "Newton", "Nguyen", "Nichols", "Nicholson", "Nielsen", "Nieves", "Nixon", "Noble", "Noel", "Nolan", "Norman", "Norris", "Norton", "Nunez", "Obrien", "Ochoa", "Oconnor", "Odom", "Odonnell", "Oliver", "Olsen", "Olson", "Oneal", "Oneil", "Oneill", "Orr", "Ortega", "Ortiz", "Osborn", "Osborne", "Owen", "Owens", "Pace", "Pacheco", "Padilla", "Page", "Palmer", "Park", "Parker", "Parks", "Parrish", "Parsons", "Pate", "Patel", "Patrick", "Patterson", "Patton", "Paul", "Payne", "Pearson", "Peck", "Pena", "Pennington", "Perez", "Perkins", "Perry", "Peters", "Petersen", "Peterson", "Petty", "Phelps", "Phillips", "Pickett", "Pierce", "Pittman", "Pitts", "Pollard", "Poole", "Pope", "Porter", "Potter", "Potts", "Powell", "Powers", "Pratt", "Preston", "Price", "Prince", "Pruitt", "Puckett", "Pugh", "Quinn", "Ramirez", "Ramos", "Ramsey", "Randall", "Randolph", "Rasmussen", "Ratliff", "Ray", "Raymond", "Reed", "Reese", "Reeves", "Reid", "Reilly", "Reyes", "Reynolds", "Rhodes", "Rice", "Rich", "Richard", "Richards", "Richardson", "Richmond", "Riddle", "Riggs", "Riley", "Rios", "Rivas", "Rivera", "Rivers", "Roach", "Robbins", "Roberson", "Roberts", "Robertson", "Robinson", "Robles", "Rocha", "Rodgers", "Rodriguez", "Rodriquez", "Rogers", "Rojas", "Rollins", "Roman", "Romero", "Rosa", "Rosales", "Rosario", "Rose", "Ross", "Roth", "Rowe", "Rowland", "Roy", "Ruiz", "Rush", "Russell", "Russo", "Rutledge", "Ryan", "Salas", "Salazar", "Salinas", "Sampson", "Sanchez", "Sanders", "Sandoval", "Sanford", "Santana", "Santiago", "Santos", "Sargent", "Saunders", "Savage", "Sawyer", "Schmidt", "Schneider", "Schroeder", "Schultz", "Schwartz", "Scott", "Sears", "Sellers", "Serrano", "Sexton", "Shaffer", "Shannon", "Sharp", "Sharpe", "Shaw", "Shelton", "Shepard", "Shepherd", "Sheppard", "Sherman", "Shields", "Short", "Silva", "Simmons", "Simon", "Simpson", "Sims", "Singleton", "Skinner", "Slater", "Sloan", "Small", "Smith", "Snider", "Snow", "Snyder", "Solis", "Solomon", "Sosa", "Soto", "Sparks", "Spears", "Spence", "Spencer", "Stafford", "Stanley", "Stanton", "Stark", "Steele", "Stein", "Stephens", "Stephenson", "Stevens", "Stevenson", "Stewart", "Stokes", "Stone", "Stout", "Strickland", "Strong", "Stuart", "Suarez", "Sullivan", "Summers", "Sutton", "Swanson", "Sweeney", "Sweet", "Sykes", "Talley", "Tanner", "Tate", "Taylor", "Terrell", "Terry", "Thomas", "Thompson", "Thornton", "Tillman", "Todd", "Torres", "Townsend", "Tran", "Travis", "Trevino", "Trujillo", "Tucker", "Turner", "Tyler", "Tyson", "Underwood", "Valdez", "Valencia", "Valentine", "Valenzuela", "Vance", "Vang", "Vargas", "Vasquez", "Vaughan", "Vaughn", "Vazquez", "Vega", "Velasquez", "Velazquez", "Velez", "Villarreal", "Vincent", "Vinson", "Wade", "Wagner", "Walker", "Wall", "Wallace", "Waller", "Walls", "Walsh", "Walter", "Walters", "Walton", "Ward", "Ware", "Warner", "Warren", "Washington", "Waters", "Watkins", "Watson", "Watts", "Weaver", "Webb", "Weber", "Webster", "Weeks", "Weiss", "Welch", "Wells", "West", "Wheeler", "Whitaker", "White", "Whitehead", "Whitfield", "Whitley", "Whitney", "Wiggins", "Wilcox", "Wilder", "Wiley", "Wilkerson", "Wilkins", "Wilkinson", "William", "Williams", "Williamson", "Willis", "Wilson", "Winters", "Wise", "Witt", "Wolf", "Wolfe", "Wong", "Wood", "Woodard", "Woods", "Woodward", "Wooten", "Workman", "Wright", "Wyatt", "Wynn", "Yang", "Yates", "York", "Young", "Zamora", "Zimmerman" };
        int[] counts = new int[4]; //для подсчета количества каждой отметки
        float sum = 0.0f;
        ListViewItem stud = new ListViewItem();

        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filled();
        }

        public void Filled()
        {
            listView1.Clear();
            //Количество предметов, если есть
            int b = 0;
            int.TryParse(textBox1.Text, out b);
            n = b;
            Col(b);
            //Количество студентов, если есть
            b = 0;
            int.TryParse(textBox2.Text, out b);
            Students(b);
        }
        public void Col(int t = 5)
        {

            string str = "Предмет";
            listView1.Columns.Add("ФИО", 120, HorizontalAlignment.Left);
            //Заполняем предметы
            for (int i = 0; i < t; i++)
                listView1.Columns.Add(str + " " + (i + 1), 70, HorizontalAlignment.Left);
            Default();
        }
        private void Default()
        {
            f = 1;
            button2.Enabled = false;
            //Заполняем дополнительные поля
            listView1.Columns.Add("2", 20, HorizontalAlignment.Left);
            listView1.Columns.Add("3", 20, HorizontalAlignment.Left);
            listView1.Columns.Add("4", 20, HorizontalAlignment.Left);
            listView1.Columns.Add("5", 20, HorizontalAlignment.Left);
            listView1.Columns.Add("Средний балл", 100, HorizontalAlignment.Left);
        }



        public void Students(int k = 10)
        {
            m = k ; //количество студентов

            int t;

            //Заполняем студентов.
            for (int i = 0; i < m; i++)
            {
                Array.Clear(counts, 0, counts.Length);
                sum = 0.0f;
                stud.SubItems.Clear();
                //Имя студента
                stud.Text = names[rand.Next(names.Length)];
                //Оценки
                for (int j = 0; j < n; j++)
                {
                    t = rand.Next(2, 6);
                    counts[t - 2]++;
                    sum += t;
                    stud.SubItems.Add(t.ToString());
                }
                sum = sum / n;
                for (int j = 0; j < 4; j++)
                    stud.SubItems.Add(counts[j].ToString());
                stud.SubItems.Add(sum.ToString("0.0"));
                listView1.Items.Add((ListViewItem)stud.Clone());
            }
        }

        //Добавить предмет
        private void button2_Click(object sender, EventArgs e)
        {
            n++;
            listView1.Columns.Add(textBox3.Text, 70, HorizontalAlignment.Left);
            button3.Enabled = true;       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("ФИО", 120, HorizontalAlignment.Left);
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            int mark;
            int.TryParse(textBox5.Text, out mark);
            if (mark < 2 || mark > 5)
                return;
            c++;
            counts[mark - 2]++;
            sum += mark;
            stud.SubItems.Add(mark.ToString());
            if (c < n)
                label3.Text = "Оценка по " + listView1.Columns[c + 1].Text;
            else
            {
                bReady.Enabled = true;
                bNext.Enabled = false;
            }
        }

        private void bReady_Click(object sender, EventArgs e)
        {
            sum = sum / n;
            for (int j = 0; j < 4; j++)
                stud.SubItems.Add(counts[j].ToString());
            stud.SubItems.Add(sum.ToString("0.0"));
            listView1.Items.Add((ListViewItem)stud.Clone());
            button3.Enabled = true;
        }

        //Добавляем студента
        private void button3_Click(object sender, EventArgs e)
        {
            if (f == 0)
                Default();
            sum = 0.0f;
            stud.SubItems.Clear();
            Array.Clear(counts, 0, counts.Length);
            bNext.Enabled = true;
            bReady.Enabled = false;
            stud.Text = textBox4.Text;
            label3.Text = "Оценка по " + listView1.Columns[1].Text;
            c = 0;
            button3.Enabled = false;
        }
        // Шрифт
        private void button4_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                for (int i = 0; i < listView1.Items.Count; i++)
                    listView1.Items[i].Font = fontDialog1.Font;
        }
        // Цвет
        private void button5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                for (int i = 0; i < listView1.Items.Count; i++)
                    listView1.Items[i].BackColor = colorDialog1.Color;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                listView1.GridLines = true;
            else
                listView1.GridLines = false;
        }

        //Число это цифры!
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
