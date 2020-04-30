#include <iostream>

class Enemy
{
	public:
		void RunAIScripts();
		void Updated(double deltaTime);
	private:
		int m_health;
		int m_damage;
};

class Boss : public Enemy
{
	public:
		void UpdateObjects(double deltaTime)
		{
		}
};

int main()
{
	  Enemy enemy;
		Boss boss;
		enemy.Update(deltaTime);
		boss.UpdateObjects(deltaTime);

}
