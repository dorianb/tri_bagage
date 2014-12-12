using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAirport.Entities;

namespace MyAirport.Data
{
    public class ModelNatif:MyAirport.Data.AbstractModel
    {
        public List<VolDefinition> vols = new List<VolDefinition> 
        { 
            /*
new VolDefinition{Id=1, CIE="4U", Date=new DateTime(2014,07,16, 06,30,00), Ligne=7403},
new VolDefinition{Id=2, CIE="4U", Date=new DateTime(2014,07,17, 06,30,00), Ligne=7403},
new VolDefinition{Id=3, CIE="4U", Date=new DateTime(2014,07,18, 06,30,00), Ligne=7403},
new VolDefinition{Id=4, CIE="4U", Date=new DateTime(2014,07,16, 06,30,00), Ligne=7407},
new VolDefinition{Id=5, CIE="4U", Date=new DateTime(2014,07,17, 06,30,00), Ligne=7407},
new VolDefinition{Id=6, CIE="4U", Date=new DateTime(2014,07,18, 06,30,00), Ligne=7407},
new VolDefinition{Id=7, CIE="8U", Date=new DateTime(2014,07,17, 06,30,00), Ligne=901},
new VolDefinition{Id=8, CIE="A3", Date=new DateTime(2014,07,17, 06,30,00), Ligne=1439},
new VolDefinition{Id=9, CIE="A3", Date=new DateTime(2014,07,18, 06,30,00), Ligne=1439},
new VolDefinition{Id=10, CIE="A3", Date=new DateTime(2014,07,17, 06,30,00), Ligne=1441},
new VolDefinition{Id=11, CIE="A3", Date=new DateTime(2014,07,18, 06,30,00), Ligne=1441},
new VolDefinition{Id=12, CIE="A3", Date=new DateTime(2014,07,17, 06,30,00), Ligne=1443},
new VolDefinition{Id=13, CIE="A3", Date=new DateTime(2014,07,18, 06,30,00), Ligne=1443},
new VolDefinition{Id=14, CIE="A3", Date=new DateTime(2014,07,17, 06,30,00), Ligne=1449},
new VolDefinition{Id=15, CIE="A3", Date=new DateTime(2014,07,18, 06,30,00), Ligne=1449},
new VolDefinition{Id=16, CIE="A3", Date=new DateTime(2014,07,17, 06,30,00), Ligne=1451},
new VolDefinition{Id=17, CIE="A3", Date=new DateTime(2014,07,18, 06,30,00), Ligne=1451},
new VolDefinition{Id=18, CIE="A3", Date=new DateTime(2014,07,17, 06,30,00), Ligne=1453},
new VolDefinition{Id=19, CIE="A3", Date=new DateTime(2014,07,18, 06,30,00), Ligne=1453},
new VolDefinition{Id=20, CIE="A3", Date=new DateTime(2014,07,18, 06,30,00), Ligne=421},
new VolDefinition{Id=21, CIE="A3", Date=new DateTime(2014,07,18, 06,30,00), Ligne=455},
new VolDefinition{Id=22, CIE="A3", Date=new DateTime(2014,07,17, 06,30,00), Ligne=463},
new VolDefinition{Id=23, CIE="A3", Date=new DateTime(2014,07,18, 06,30,00), Ligne=463},
new VolDefinition{Id=24, CIE="A3", Date=new DateTime(2014,07,17, 06,30,00), Ligne=593},
new VolDefinition{Id=25, CIE="A3", Date=new DateTime(2014,07,18, 06,30,00), Ligne=593},
new VolDefinition{Id=26, CIE="A3", Date=new DateTime(2014,07,17, 06,30,00), Ligne=611},
new VolDefinition{Id=27, CIE="A3", Date=new DateTime(2014,07,18, 06,30,00), Ligne=611},
new VolDefinition{Id=28, CIE="A3", Date=new DateTime(2014,07,17, 06,30,00), Ligne=613},
new VolDefinition{Id=29, CIE="A3", Date=new DateTime(2014,07,17, 06,30,00), Ligne=615},
new VolDefinition{Id=30, CIE="A3", Date=new DateTime(2014,07,18, 06,30,00), Ligne=615},
new VolDefinition{Id=31, CIE="AC", Date=new DateTime(2014,07,17, 06,30,00), Ligne=2469},
new VolDefinition{Id=32, CIE="AC", Date=new DateTime(2014,07,18, 06,30,00), Ligne=2469},
new VolDefinition{Id=33, CIE="AC", Date=new DateTime(2014,07,17, 06,30,00), Ligne=2471},
new VolDefinition{Id=34, CIE="AC", Date=new DateTime(2014,07,18, 06,30,00), Ligne=2471},
new VolDefinition{Id=35, CIE="AC", Date=new DateTime(2014,07,17, 06,30,00), Ligne=2515},
new VolDefinition{Id=36, CIE="AC", Date=new DateTime(2014,07,18, 06,30,00), Ligne=2515},
new VolDefinition{Id=37, CIE="AC", Date=new DateTime(2014,07,17, 06,30,00), Ligne=5937},
new VolDefinition{Id=38, CIE="AC", Date=new DateTime(2014,07,18, 06,30,00), Ligne=5937},
new VolDefinition{Id=39, CIE="AC", Date=new DateTime(2014,07,18, 06,30,00), Ligne=6880},
new VolDefinition{Id=40, CIE="AT", Date=new DateTime(2014,07,17, 06,30,00), Ligne=8823},
new VolDefinition{Id=41, CIE="BR", Date=new DateTime(2014,07,17, 06,30,00), Ligne=088},
new VolDefinition{Id=42, CIE="BR", Date=new DateTime(2014,07,18, 06,30,00), Ligne=088},
new VolDefinition{Id=43, CIE="CA", Date=new DateTime(2014,07,17, 06,30,00), Ligne=7105},
new VolDefinition{Id=44, CIE="CA", Date=new DateTime(2014,07,18, 06,30,00), Ligne=7105},
new VolDefinition{Id=45, CIE="CA", Date=new DateTime(2014,07,18, 06,30,00), Ligne=834},
new VolDefinition{Id=46, CIE="CA", Date=new DateTime(2014,07,17, 06,30,00), Ligne=934},
new VolDefinition{Id=47, CIE="CA", Date=new DateTime(2014,07,18, 06,30,00), Ligne=934},
new VolDefinition{Id=48, CIE="CTM", Date=new DateTime(2014,07,18, 06,30,00), Ligne=0005},
new VolDefinition{Id=49, CIE="CTM", Date=new DateTime(2014,07,17, 06,30,00), Ligne=1101},
new VolDefinition{Id=50, CIE="CTM", Date=new DateTime(2014,07,18, 06,30,00), Ligne=1101},
new VolDefinition{Id=51, CIE="EI", Date=new DateTime(2014,07,17, 06,30,00), Ligne=521},
new VolDefinition{Id=52, CIE="EI", Date=new DateTime(2014,07,18, 06,30,00), Ligne=521},
new VolDefinition{Id=53, CIE="EI", Date=new DateTime(2014,07,17, 06,30,00), Ligne=523},
new VolDefinition{Id=54, CIE="EI", Date=new DateTime(2014,07,18, 06,30,00), Ligne=523},
new VolDefinition{Id=55, CIE="EI", Date=new DateTime(2014,07,17, 06,30,00), Ligne=525},
new VolDefinition{Id=56, CIE="EI", Date=new DateTime(2014,07,18, 06,30,00), Ligne=525},
new VolDefinition{Id=57, CIE="EI", Date=new DateTime(2014,07,17, 06,30,00), Ligne=529},
new VolDefinition{Id=58, CIE="EI", Date=new DateTime(2014,07,18, 06,30,00), Ligne=529},
new VolDefinition{Id=59, CIE="EI", Date=new DateTime(2014,07,17, 06,30,00), Ligne=823},
new VolDefinition{Id=60, CIE="EI", Date=new DateTime(2014,07,18, 06,30,00), Ligne=823},
new VolDefinition{Id=61, CIE="FI", Date=new DateTime(2014,07,17, 06,30,00), Ligne=541},
new VolDefinition{Id=62, CIE="FI", Date=new DateTime(2014,07,18, 06,30,00), Ligne=541},
new VolDefinition{Id=63, CIE="FI", Date=new DateTime(2014,07,17, 06,30,00), Ligne=543},
new VolDefinition{Id=64, CIE="FI", Date=new DateTime(2014,07,18, 06,30,00), Ligne=543},
new VolDefinition{Id=65, CIE="FI", Date=new DateTime(2014,07,18, 06,30,00), Ligne=547},
new VolDefinition{Id=66, CIE="FS", Date=new DateTime(2014,07,18, 06,30,00), Ligne=101},
new VolDefinition{Id=67, CIE="FS", Date=new DateTime(2014,07,17, 06,30,00), Ligne=105},
new VolDefinition{Id=68, CIE="FS", Date=new DateTime(2014,07,18, 06,30,00), Ligne=105},
new VolDefinition{Id=69, CIE="FS", Date=new DateTime(2014,07,17, 06,30,00), Ligne=111},
new VolDefinition{Id=70, CIE="IY", Date=new DateTime(2014,07,18, 06,30,00), Ligne=749},
new VolDefinition{Id=71, CIE="JJ", Date=new DateTime(2014,07,17, 06,30,00), Ligne=8101},
new VolDefinition{Id=72, CIE="JJ", Date=new DateTime(2014,07,18, 06,30,00), Ligne=8101},
new VolDefinition{Id=73, CIE="JJ", Date=new DateTime(2014,07,17, 06,30,00), Ligne=8384},
new VolDefinition{Id=74, CIE="JJ", Date=new DateTime(2014,07,18, 06,30,00), Ligne=8384},
new VolDefinition{Id=75, CIE="JJ", Date=new DateTime(2014,07,17, 06,30,00), Ligne=8490},
new VolDefinition{Id=76, CIE="JJ", Date=new DateTime(2014,07,18, 06,30,00), Ligne=8490},
new VolDefinition{Id=77, CIE="JJ", Date=new DateTime(2014,07,17, 06,30,00), Ligne=8492},
new VolDefinition{Id=78, CIE="JJ", Date=new DateTime(2014,07,18, 06,30,00), Ligne=8492},
new VolDefinition{Id=79, CIE="JP", Date=new DateTime(2014,07,17, 06,30,00), Ligne=323},
new VolDefinition{Id=80, CIE="JP", Date=new DateTime(2014,07,18, 06,30,00), Ligne=323},
new VolDefinition{Id=81, CIE="KU", Date=new DateTime(2014,07,18, 06,30,00), Ligne=166},
new VolDefinition{Id=82, CIE="LC", Date=new DateTime(2014,07,15, 06,30,00), Ligne=012},
new VolDefinition{Id=83, CIE="LC", Date=new DateTime(2014,07,17, 06,30,00), Ligne=012},
new VolDefinition{Id=84, CIE="LC", Date=new DateTime(2014,07,16, 06,30,00), Ligne=032},
new VolDefinition{Id=85, CIE="LC", Date=new DateTime(2014,07,18, 06,30,00), Ligne=032},
new VolDefinition{Id=86, CIE="LH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=1027},
new VolDefinition{Id=87, CIE="LH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=1027},
new VolDefinition{Id=88, CIE="LH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=1029},
new VolDefinition{Id=89, CIE="LH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=1029},
new VolDefinition{Id=90, CIE="LH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=1031},
new VolDefinition{Id=91, CIE="LH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=1031},
new VolDefinition{Id=92, CIE="LH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=1035},
new VolDefinition{Id=93, CIE="LH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=1035},
new VolDefinition{Id=94, CIE="LH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=1037},
new VolDefinition{Id=95, CIE="LH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=1037},
new VolDefinition{Id=96, CIE="LH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=1041},
new VolDefinition{Id=97, CIE="LH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=1041},
new VolDefinition{Id=98, CIE="LH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=1043},
new VolDefinition{Id=99, CIE="LH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=1043},
new VolDefinition{Id=100, CIE="LH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=1047},
new VolDefinition{Id=101, CIE="LH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=1047},
new VolDefinition{Id=102, CIE="LH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=1051},
new VolDefinition{Id=103, CIE="LH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=1051},
new VolDefinition{Id=104, CIE="LH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=1053},
new VolDefinition{Id=105, CIE="LH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=1053},
new VolDefinition{Id=106, CIE="LH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=2227},
new VolDefinition{Id=107, CIE="LH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=2227},
new VolDefinition{Id=108, CIE="LH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=2229},
new VolDefinition{Id=109, CIE="LH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=2229},
new VolDefinition{Id=110, CIE="LH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=2231},
new VolDefinition{Id=111, CIE="LH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=2231},
new VolDefinition{Id=112, CIE="LH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=2233},
new VolDefinition{Id=113, CIE="LH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=2233},
new VolDefinition{Id=114, CIE="LH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=2235},
new VolDefinition{Id=115, CIE="LH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=2235},
new VolDefinition{Id=116, CIE="LH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=2237},
new VolDefinition{Id=117, CIE="LH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=2237},
new VolDefinition{Id=118, CIE="LH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=2239},
new VolDefinition{Id=119, CIE="LH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=2239},
new VolDefinition{Id=120, CIE="LH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=3219},
new VolDefinition{Id=121, CIE="LH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=3219},
new VolDefinition{Id=122, CIE="LH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=3223},
new VolDefinition{Id=123, CIE="LH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=3223},
new VolDefinition{Id=124, CIE="LH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=3225},
new VolDefinition{Id=125, CIE="LH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=3225},
new VolDefinition{Id=126, CIE="LH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=3241},
new VolDefinition{Id=127, CIE="LH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=3241},
new VolDefinition{Id=128, CIE="LH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=3245},
new VolDefinition{Id=129, CIE="LH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=3245},
new VolDefinition{Id=130, CIE="LH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=7641},
new VolDefinition{Id=131, CIE="LH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=7641},
new VolDefinition{Id=132, CIE="LH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=7959},
new VolDefinition{Id=133, CIE="LH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=7959},
new VolDefinition{Id=134, CIE="LH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=7961},
new VolDefinition{Id=135, CIE="LH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=7961},
new VolDefinition{Id=136, CIE="LH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=9334},
new VolDefinition{Id=137, CIE="LH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=9334},
new VolDefinition{Id=138, CIE="LO", Date=new DateTime(2014,07,17, 06,30,00), Ligne=332},
new VolDefinition{Id=139, CIE="LO", Date=new DateTime(2014,07,18, 06,30,00), Ligne=332},
new VolDefinition{Id=140, CIE="LO", Date=new DateTime(2014,07,17, 06,30,00), Ligne=334},
new VolDefinition{Id=1, CIE="LO", Date=new DateTime(2014,07,18, 06,30,00), Ligne=334},
new VolDefinition{Id=1, CIE="LO", Date=new DateTime(2014,07,17, 06,30,00), Ligne=336},
new VolDefinition{Id=1, CIE="LO", Date=new DateTime(2014,07,18, 06,30,00), Ligne=336},
new VolDefinition{Id=1, CIE="LT", Date=new DateTime(2014,07,17, 06,30,00), Ligne=202},
new VolDefinition{Id=1, CIE="LT", Date=new DateTime(2014,07,17, 06,30,00), Ligne=202},
new VolDefinition{Id=1, CIE="LT", Date=new DateTime(2014,07,18, 06,30,00), Ligne=202},
new VolDefinition{Id=1, CIE="LX", Date=new DateTime(2014,07,17, 06,30,00), Ligne=633},
new VolDefinition{Id=1, CIE="LX", Date=new DateTime(2014,07,18, 06,30,00), Ligne=633},
new VolDefinition{Id=1, CIE="LX", Date=new DateTime(2014,07,17, 06,30,00), Ligne=635},
new VolDefinition{Id=1, CIE="LX", Date=new DateTime(2014,07,18, 06,30,00), Ligne=635},
new VolDefinition{Id=1, CIE="LX", Date=new DateTime(2014,07,17, 06,30,00), Ligne=639},
new VolDefinition{Id=1, CIE="LX", Date=new DateTime(2014,07,18, 06,30,00), Ligne=639},
new VolDefinition{Id=1, CIE="LX", Date=new DateTime(2014,07,17, 06,30,00), Ligne=645},
new VolDefinition{Id=1, CIE="LX", Date=new DateTime(2014,07,18, 06,30,00), Ligne=645},
new VolDefinition{Id=1, CIE="LX", Date=new DateTime(2014,07,17, 06,30,00), Ligne=647},
new VolDefinition{Id=1, CIE="LX", Date=new DateTime(2014,07,18, 06,30,00), Ligne=647},
new VolDefinition{Id=1, CIE="LX", Date=new DateTime(2014,07,17, 06,30,00), Ligne=657},
new VolDefinition{Id=1, CIE="LX", Date=new DateTime(2014,07,18, 06,30,00), Ligne=657},
new VolDefinition{Id=1, CIE="MH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=021},
new VolDefinition{Id=1, CIE="MH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=021},
new VolDefinition{Id=1, CIE="MH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=021},
new VolDefinition{Id=1, CIE="MS", Date=new DateTime(2014,07,17, 06,30,00), Ligne=800},
new VolDefinition{Id=1, CIE="MS", Date=new DateTime(2014,07,18, 06,30,00), Ligne=800},
new VolDefinition{Id=1, CIE="MS", Date=new DateTime(2014,07,17, 06,30,00), Ligne=804},
new VolDefinition{Id=1, CIE="MS", Date=new DateTime(2014,07,18, 06,30,00), Ligne=804},
new VolDefinition{Id=1, CIE="NH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=206},
new VolDefinition{Id=1, CIE="NH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=206},
new VolDefinition{Id=1, CIE="NH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=216},
new VolDefinition{Id=1, CIE="NH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=216},
new VolDefinition{Id=1, CIE="NH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=5872},
new VolDefinition{Id=1, CIE="NH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=5872},
new VolDefinition{Id=1, CIE="NH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=6016},
new VolDefinition{Id=1, CIE="NH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=6016},
new VolDefinition{Id=1, CIE="NH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=6020},
new VolDefinition{Id=1, CIE="NH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=6020},
new VolDefinition{Id=1, CIE="NH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=6023},
new VolDefinition{Id=1, CIE="NH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=6023},
new VolDefinition{Id=1, CIE="NH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=6025},
new VolDefinition{Id=1, CIE="NH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=6025},
new VolDefinition{Id=1, CIE="NH", Date=new DateTime(2014,07,17, 06,30,00), Ligne=6711},
new VolDefinition{Id=1, CIE="NH", Date=new DateTime(2014,07,18, 06,30,00), Ligne=6711},
new VolDefinition{Id=1, CIE="OA", Date=new DateTime(2014,07,17, 06,30,00), Ligne=6611},
new VolDefinition{Id=1, CIE="OA", Date=new DateTime(2014,07,18, 06,30,00), Ligne=6611},
new VolDefinition{Id=1, CIE="OA", Date=new DateTime(2014,07,17, 06,30,00), Ligne=6613},
new VolDefinition{Id=1, CIE="OA", Date=new DateTime(2014,07,17, 06,30,00), Ligne=6615},
new VolDefinition{Id=1, CIE="OA", Date=new DateTime(2014,07,18, 06,30,00), Ligne=6615},
new VolDefinition{Id=1, CIE="OU", Date=new DateTime(2014,07,17, 06,30,00), Ligne=471},
new VolDefinition{Id=1, CIE="OU", Date=new DateTime(2014,07,18, 06,30,00), Ligne=471},
new VolDefinition{Id=1, CIE="OU", Date=new DateTime(2014,07,17, 06,30,00), Ligne=477},
new VolDefinition{Id=1, CIE="OU", Date=new DateTime(2014,07,18, 06,30,00), Ligne=477},
new VolDefinition{Id=1, CIE="OZ", Date=new DateTime(2014,07,18, 06,30,00), Ligne=502},
new VolDefinition{Id=1, CIE="PK", Date=new DateTime(2014,07,18, 06,30,00), Ligne=750},
new VolDefinition{Id=1, CIE="QC", Date=new DateTime(2014,07,17, 06,30,00), Ligne=101},
new VolDefinition{Id=1, CIE="QC", Date=new DateTime(2014,07,18, 06,30,00), Ligne=101},
new VolDefinition{Id=1, CIE="QR", Date=new DateTime(2014,07,17, 06,30,00), Ligne=038},
new VolDefinition{Id=1, CIE="QR", Date=new DateTime(2014,07,18, 06,30,00), Ligne=038},
new VolDefinition{Id=1, CIE="QR", Date=new DateTime(2014,07,17, 06,30,00), Ligne=040},
new VolDefinition{Id=1, CIE="QR", Date=new DateTime(2014,07,18, 06,30,00), Ligne=040},
new VolDefinition{Id=1, CIE="QR", Date=new DateTime(2014,07,17, 06,30,00), Ligne=042},
new VolDefinition{Id=1, CIE="QR", Date=new DateTime(2014,07,18, 06,30,00), Ligne=042},
new VolDefinition{Id=1, CIE="SA", Date=new DateTime(2014,07,17, 06,30,00), Ligne=7555},
new VolDefinition{Id=1, CIE="SA", Date=new DateTime(2014,07,18, 06,30,00), Ligne=7555},
new VolDefinition{Id=1, CIE="SA", Date=new DateTime(2014,07,17, 06,30,00), Ligne=7557},
new VolDefinition{Id=1, CIE="SA", Date=new DateTime(2014,07,18, 06,30,00), Ligne=7557},
new VolDefinition{Id=1, CIE="SI", Date=new DateTime(2014,07,18, 06,30,00), Ligne=284},
new VolDefinition{Id=1, CIE="SK", Date=new DateTime(2014,07,17, 06,30,00), Ligne=1560},
new VolDefinition{Id=1, CIE="SK", Date=new DateTime(2014,07,18, 06,30,00), Ligne=1560},
new VolDefinition{Id=1, CIE="SK", Date=new DateTime(2014,07,17, 06,30,00), Ligne=566},
new VolDefinition{Id=1, CIE="SK", Date=new DateTime(2014,07,18, 06,30,00), Ligne=566},
new VolDefinition{Id=1, CIE="SK", Date=new DateTime(2014,07,17, 06,30,00), Ligne=568},
new VolDefinition{Id=1, CIE="SK", Date=new DateTime(2014,07,18, 06,30,00), Ligne=568},
new VolDefinition{Id=1, CIE="SK", Date=new DateTime(2014,07,17, 06,30,00), Ligne=574},
new VolDefinition{Id=1, CIE="SK", Date=new DateTime(2014,07,18, 06,30,00), Ligne=574},
new VolDefinition{Id=1, CIE="SK", Date=new DateTime(2014,07,17, 06,30,00), Ligne=580},
new VolDefinition{Id=1, CIE="SK", Date=new DateTime(2014,07,18, 06,30,00), Ligne=580},
new VolDefinition{Id=1, CIE="SK", Date=new DateTime(2014,07,17, 06,30,00), Ligne=830},
new VolDefinition{Id=1, CIE="SK", Date=new DateTime(2014,07,18, 06,30,00), Ligne=830},
new VolDefinition{Id=1, CIE="SK", Date=new DateTime(2014,07,17, 06,30,00), Ligne=834},
new VolDefinition{Id=1, CIE="SK", Date=new DateTime(2014,07,18, 06,30,00), Ligne=834},
new VolDefinition{Id=1, CIE="SK", Date=new DateTime(2014,07,17, 06,30,00), Ligne=836},
new VolDefinition{Id=1, CIE="SK", Date=new DateTime(2014,07,18, 06,30,00), Ligne=836},
new VolDefinition{Id=1, CIE="SK", Date=new DateTime(2014,07,17, 06,30,00), Ligne=8450},
new VolDefinition{Id=1, CIE="SK", Date=new DateTime(2014,07,17, 06,30,00), Ligne=8497},
new VolDefinition{Id=1, CIE="SK", Date=new DateTime(2014,07,18, 06,30,00), Ligne=8497},
new VolDefinition{Id=1, CIE="SK", Date=new DateTime(2014,07,17, 06,30,00), Ligne=8499},
new VolDefinition{Id=1, CIE="SK", Date=new DateTime(2014,07,18, 06,30,00), Ligne=8499},
new VolDefinition{Id=1, CIE="SN", Date=new DateTime(2014,07,17, 06,30,00), Ligne=3632},
new VolDefinition{Id=1, CIE="SN", Date=new DateTime(2014,07,18, 06,30,00), Ligne=3632},
new VolDefinition{Id=1, CIE="SN", Date=new DateTime(2014,07,17, 06,30,00), Ligne=3634},
new VolDefinition{Id=1, CIE="SN", Date=new DateTime(2014,07,18, 06,30,00), Ligne=3634},
new VolDefinition{Id=1, CIE="SQ", Date=new DateTime(2014,07,17, 06,30,00), Ligne=333},
new VolDefinition{Id=1, CIE="SQ", Date=new DateTime(2014,07,18, 06,30,00), Ligne=333},
new VolDefinition{Id=1, CIE="TG", Date=new DateTime(2014,07,17, 06,30,00), Ligne=931},
new VolDefinition{Id=1, CIE="TG", Date=new DateTime(2014,07,18, 06,30,00), Ligne=931},
new VolDefinition{Id=1, CIE="TK", Date=new DateTime(2014,07,18, 06,30,00), Ligne=1818},
new VolDefinition{Id=1, CIE="TK", Date=new DateTime(2014,07,17, 06,30,00), Ligne=1820},
new VolDefinition{Id=1, CIE="TK", Date=new DateTime(2014,07,18, 06,30,00), Ligne=1820},
new VolDefinition{Id=1, CIE="TK", Date=new DateTime(2014,07,17, 06,30,00), Ligne=1822},
new VolDefinition{Id=1, CIE="TK", Date=new DateTime(2014,07,18, 06,30,00), Ligne=1822},
new VolDefinition{Id=1, CIE="TK", Date=new DateTime(2014,07,17, 06,30,00), Ligne=1824},
new VolDefinition{Id=1, CIE="TK", Date=new DateTime(2014,07,18, 06,30,00), Ligne=1824},
new VolDefinition{Id=1, CIE="TK", Date=new DateTime(2014,07,17, 06,30,00), Ligne=1828},
new VolDefinition{Id=1, CIE="TK", Date=new DateTime(2014,07,18, 06,30,00), Ligne=1828},
new VolDefinition{Id=1, CIE="TK", Date=new DateTime(2014,07,17, 06,30,00), Ligne=1830},
new VolDefinition{Id=1, CIE="TK", Date=new DateTime(2014,07,18, 06,30,00), Ligne=1830},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,17, 06,30,00), Ligne=875},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,18, 06,30,00), Ligne=875},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,17, 06,30,00), Ligne=8817},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,18, 06,30,00), Ligne=8817},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,17, 06,30,00), Ligne=905},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,18, 06,30,00), Ligne=905},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,17, 06,30,00), Ligne=9069},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,18, 06,30,00), Ligne=9069},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,17, 06,30,00), Ligne=9073},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,18, 06,30,00), Ligne=9073},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,17, 06,30,00), Ligne=914},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,18, 06,30,00), Ligne=914},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,17, 06,30,00), Ligne=9207},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,18, 06,30,00), Ligne=9207},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,17, 06,30,00), Ligne=9209},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,18, 06,30,00), Ligne=9209},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,17, 06,30,00), Ligne=9323},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,18, 06,30,00), Ligne=9323},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,17, 06,30,00), Ligne=9356},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,18, 06,30,00), Ligne=9356},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,17, 06,30,00), Ligne=9430},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,18, 06,30,00), Ligne=9430},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,17, 06,30,00), Ligne=9458},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,18, 06,30,00), Ligne=9458},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,17, 06,30,00), Ligne=9498},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,18, 06,30,00), Ligne=9498},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,17, 06,30,00), Ligne=9516},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,18, 06,30,00), Ligne=9516},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,17, 06,30,00), Ligne=9847},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,18, 06,30,00), Ligne=9847},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,17, 06,30,00), Ligne=986},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,18, 06,30,00), Ligne=986},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,17, 06,30,00), Ligne=991},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,18, 06,30,00), Ligne=991},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,17, 06,30,00), Ligne=9920},
new VolDefinition{Id=1, CIE="UA", Date=new DateTime(2014,07,18, 06,30,00), Ligne=9920},
new VolDefinition{Id=1, CIE="UL", Date=new DateTime(2014,07,18, 06,30,00), Ligne=564},
new VolDefinition{Id=1, CIE="US", Date=new DateTime(2014,07,17, 06,30,00), Ligne=4819},
new VolDefinition{Id=1, CIE="US", Date=new DateTime(2014,07,18, 06,30,00), Ligne=4819},
new VolDefinition{Id=1, CIE="US", Date=new DateTime(2014,07,17, 06,30,00), Ligne=6410},
new VolDefinition{Id=1, CIE="US", Date=new DateTime(2014,07,18, 06,30,00), Ligne=6410}
*/
        };

        public List<BagageDefinition> bagages = new List<BagageDefinition> 
        { 
            new BagageDefinition{Id=1,IdVol=1,  CodeIATA=234152438, DateCreation=new DateTime(2014,10,03, 05,18,45)},
            new BagageDefinition{Id=2,IdVol=1,  CodeIATA=234152439, DateCreation=new DateTime(2014,10,03, 05,18,52)},
            new BagageDefinition{Id=3,IdVol=1,  CodeIATA=234152440, DateCreation=new DateTime(2014,10,03, 05,52,28)},
            new BagageDefinition{Id=4,IdVol=1,  CodeIATA=234164259, DateCreation=new DateTime(2014,10,03, 06,08,45)},

            new BagageDefinition{Id=5,IdVol=2,  CodeIATA=267382930, DateCreation=new DateTime(2014,10,03, 06,13,57)},

            new BagageDefinition{Id=17,IdVol=null, CodeIATA=127627446, DateCreation=new DateTime(2014,10,03, 05,18,45)},
            
            new BagageDefinition{Id=6,IdVol=4,  CodeIATA=749394858, DateCreation=new DateTime(2014,10,04, 06,24,45)},
            new BagageDefinition{Id=7,IdVol=4,  CodeIATA=109004844, DateCreation=new DateTime(2014,10,04, 06,12,45)},
            new BagageDefinition{Id=8,IdVol=4,  CodeIATA=162748393, DateCreation=new DateTime(2014,10,04, 07,36,45)},

            new BagageDefinition{Id=9,IdVol=5,  CodeIATA=023480234, DateCreation=new DateTime(2014,10,04, 12,23,45)},
            new BagageDefinition{Id=10,IdVol=5, CodeIATA=003248745, DateCreation=new DateTime(2014,10,04, 11,32,45)},
            new BagageDefinition{Id=11,IdVol=5, CodeIATA=126783433, DateCreation=new DateTime(2014,10,04, 13,42,45)},
            new BagageDefinition{Id=12,IdVol=5, CodeIATA=219843893, DateCreation=new DateTime(2014,10,04, 10,23,45)},

            new BagageDefinition{Id=13,IdVol=6, CodeIATA=173878732, DateCreation=new DateTime(2014,10,04, 15,52,45)},
            new BagageDefinition{Id=14,IdVol=6, CodeIATA=320954033, DateCreation=new DateTime(2014,10,04, 12,35,45)},
            new BagageDefinition{Id=15,IdVol=6, CodeIATA=345949590, DateCreation=new DateTime(2014,10,04, 12,12,45)},
            new BagageDefinition{Id=16,IdVol=6, CodeIATA=128734743, DateCreation=new DateTime(2014,10,04, 13,15,45)}
        };

        #region Gestion des vols
        public override VolDefinition GetVol(int idVol)
        {
            foreach (VolDefinition v in this.vols)
            {
                if (v.Id == idVol)
                    return v;
            }
            return null;
        }

        public override List<VolDefinition> GetVols(VolCriteres criteres)
        {
            List<VolDefinition> res = new List<VolDefinition>();
            foreach (VolDefinition v in this.vols)
            {
                if (ValideCritere(v, criteres))
                    res.Add(v);
            }
            return res;
        }

        private bool ValideCritere(VolDefinition vol, VolCriteres criteres)
        {
            if (criteres.dateDebut == DateTime.MinValue) criteres.dateDebut = DateTime.Now.Date;
            if (criteres.dateFin == DateTime.MinValue) criteres.dateFin = DateTime.Now.Date.AddDays(1);

            if (criteres.Compagnies == null)
            {
                if (vol.Date >= criteres.dateDebut & vol.Date <= criteres.dateFin)
                    return true;
                else
                    return false;
            }
            else if (criteres.Compagnies.Contains(vol.CIE))
            {
                if (vol.Date >= criteres.dateDebut & vol.Date <= criteres.dateFin)
                    return true;
                else
                    return false;
            }
            return false;
        }
        #endregion

        #region Bagages
        public override BagageDefinition GetBagage(int idBagage)
        {
            foreach (BagageDefinition b in this.bagages)
            {
                if (b.Id == idBagage)
                    return b;
            }
            return null;
        }

        public override List<BagageDefinition> GetBagages(BagageCriteres criteres)
        {
            List<BagageDefinition> res = new List<BagageDefinition>();
            foreach (BagageDefinition b in this.bagages)
            {
                if (ValideCritere(b, criteres))
                    res.Add(b);
            }
            return res;
        }

        private bool ValideCritere(BagageDefinition bag, BagageCriteres criteres)
        {
            if (criteres.DateDebut == DateTime.MinValue) criteres.DateDebut = DateTime.Now.Date;
            if (criteres.DateFin == DateTime.MinValue) criteres.DateFin = DateTime.Now.Date.AddDays(1);

            if (criteres.Compagnies == null)
            {
                if (bag.DateCreation >= criteres.DateDebut & bag.DateCreation <= criteres.DateFin)
                    return true;
                else
                    return false;
            }
            return false;
        }
        #endregion

    }
}
