#include <amxmodx>
#include <amxmisc>
#include <fun>
#include <cstrike>

#define PLUGIN "The Smartest"
#define VERSION "1.0"
#define AUTHOR "Krevedko"

//new string_nums
new question[131]
new answer[64]
new quest[64]
new nick_winner[32]
new results
new string_num
new random_quest
new SayText
new bool:HasC4[33]

// Cvar's
new red, green, blue
new money, awp, strip_weapon, health, armor, kevlar, sound

public plugin_init() {
	register_plugin(PLUGIN, VERSION, AUTHOR)
	register_logevent("newround", 2, "1=Round_Start");
	red = register_cvar("sm_red","0");
	green = register_cvar("sm_green","255");
	blue = register_cvar("sm_blue","0");
	money = register_cvar("sm_money","3500");
	awp = register_cvar("sm_awp","1");
	sound = register_cvar("sm_sound","1");
	health = register_cvar("sm_health","15");
	armor = register_cvar("sm_armor","100");
	kevlar = register_cvar("sm_kevlar","1");
	strip_weapon = register_cvar("sm_strip","1");
	register_clcmd("say /vopros","resultats");
	register_clcmd("say /question","resultats");
	register_clcmd("say /winner", "winner");
	register_clcmd("say","check_results");
	register_clcmd("say_team","check_results");
	SayText = get_user_msgid("SayText");
	readfiles()
}

public plugin_precache() 
{
  precache_sound("the_smart/pipewarp.wav")
  return PLUGIN_CONTINUE
}

public readfiles()
{
	if (!file_exists("addons/amxmodx/configs/questions.ini"))
	{
	write_file("addons/amxmodx/configs/questions.ini", ";Това е файла с въпросите и техните отговори. Как трябва да изглежда файла:^n;^"въпрос^" ^"отговор^"^n^"1+1^" ^"2^"", -1) 
}
}

public newround()
{
	results = 0
	new txtlen
	string_num = file_size("addons/amxmodx/configs/questions.ini", 1)
	random_quest = random_num ( 1,string_num )
	read_file("addons/amxmodx/configs/questions.ini", random_quest, question, 130, txtlen)
	while ( (question[0] == ';' || equali(question,"")) )
	{
		random_quest = random_num ( 1,string_num )
		read_file("addons/amxmodx/configs/questions.ini", random_quest, question, 130, txtlen)
	}
	
	// парсим
	trim(question)
	
	parse(question, quest, sizeof(quest) , answer, sizeof(answer))
	
	
	set_hudmessage(get_pcvar_num(red), get_pcvar_num(green), get_pcvar_num(blue), 0.03, 0.55, 0, 6.0, 12.0, 0.2, 0.2, -1)
	show_hudmessage(0, "Конкурс: %s = ?", quest)
}



public check_results(id)
{

static chat[192];
read_args(chat, sizeof(chat) - 1);
remove_quotes(chat);

if ( results == 0 ) { // проверка за наличност на отговор

if (equali(chat, answer ))
{
go_nagrada(id)
}
} else
	 
if (chat[0] == '-' || chat[0] == '1' || chat[0] == '2' || chat[0] == '3' || chat[0] == '4' || chat[0] == '5' || chat[0] == '6' || chat[0] == '7' ||
chat[0] == '8' || chat[0] == '9' || chat[0] == '0')
print_col_chat(0, "^4К sorry player ^3%s ^4already I answered this question and received an award.", nick_winner) // 
}

public go_nagrada(id) // Награда
{
results = 1 // записване на отговор

if (get_pcvar_num(sound) == 1) {
client_cmd(0, "spk the_smart/pipewarp" )
}

if (is_user_alive(id)) {
if (get_pcvar_num(awp) == 1)
{
if (get_pcvar_num(strip_weapon) == 1)
{

if (user_has_weapon(id, CSW_C4) && get_user_team(id) == 1)
HasC4[id] = true;
else
HasC4[id] = false;

strip_user_weapons(id)

if (HasC4[id])
{
give_item(id, "weapon_c4");
cs_set_user_plant( id );
}

give_item(id, "weapon_knife")
give_item(id, "weapon_deagle")
cs_set_user_bpammo( id, CSW_DEAGLE, 35 )

}
give_item(id, "weapon_awp")
cs_set_user_bpammo( id, CSW_AWP, 20 )
}
if ( get_pcvar_num(kevlar) == 1 ) {
give_item(id, "item_kevlar")
}
new give_health = get_user_health(id) + get_pcvar_num(health)
set_user_health(id, give_health)
new give_armor = get_pcvar_num(armor)
set_user_armor(id, give_armor)
}	
get_user_name(id,nick_winner,31);
new give_money = cs_get_user_money(id) + get_pcvar_num(money)
cs_set_user_money(id, give_money)
print_col_chat(0, "^4On question of the contest the first answer ^3%s ^4and received award! ^3%i ^4$, ^3%i ^4hp, ^3%i ^4arrmor", nick_winner, get_pcvar_num(money), get_pcvar_num(health),
get_pcvar_num(armor))
if ( get_pcvar_num(awp) == 1)
print_col_chat(0, "^4и ^3AWP")
}

public winner(id)
{
	if ( results == 1 )
	{
	print_col_chat(id, "^4On question of the contest the first answer ^3%s ^4and received award! ^3%i ^4$, ^3%i ^4hp, ^3%i ^4arrmor", nick_winner, get_pcvar_num(money), get_pcvar_num(health),
	get_pcvar_num(armor))
	if ( get_pcvar_num(awp) == 1)
	print_col_chat(id, "^4и ^3AWP")
	} else
	print_col_chat(id, "^4The winner yet. You'll be the first?")
}

public resultats(id)
{
set_hudmessage(get_pcvar_num(red), get_pcvar_num(green), get_pcvar_num(blue), 0.03, 0.55, 0, 6.0, 12.0, 0.2, 0.2, -1)
if ( results == 1 )
{
show_hudmessage(id, "The contest is over. Winner in chat")
print_col_chat(id, "^4On question of the contest the first answer ^3%s ^4and received award! ^3%i ^4$, ^3%i ^4hp, ^3%i ^4arrmor", nick_winner, get_pcvar_num(money), get_pcvar_num(health),
get_pcvar_num(armor))
if ( get_pcvar_num(awp) == 1)
print_col_chat(id, "^4и ^3AWP")
} else
{
show_hudmessage(id, "Contest: %s = ?", quest)
}
}

stock print_col_chat(const id, const input[], any:...) 
{ 
    new count = 1, players[32]; 
    static msg[191]; 
    vformat(msg, 190, input, 3); 
    replace_all(msg, 190, "!g", "^4"); // Green Color 
    replace_all(msg, 190, "!y", "^1"); // Default Color (у©°  ж№«ој©) 
    replace_all(msg, 190, "!t", "^3"); // Team Color 
    if (id) players[0] = id; else get_players(players, count, "ch"); 
    { 
        for ( new i = 0; i < count; i++ ) 
        { 
            if ( is_user_connected(players[i]) ) 
            {
                message_begin(MSG_ONE_UNRELIABLE, SayText, _, players[i]); 
                write_byte(players[i]); 
                write_string(msg); 
                message_end();
            } 
        } 
    } 
}