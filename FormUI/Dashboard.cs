using LinqLibrary;

namespace FormUI
{
    public partial class Dashboard : Form
    {

        List<Person> people = ListManager.LoadSampleData();
        public Dashboard()
        {
            InitializeComponent();
            InitializeBindings();
        }

        private void InitializeBindings()
        {
            allPeopleDropdown.DataSource = people;
            allPeopleDropdown.DisplayMember = "FullName";
            filteredPeopleList.DataSource = people.Where(x => x.YearsExperience > 2).ToList();
            filteredPeopleList.DisplayMember = "FullName";


        }

        public void UpdateBindings()
        {
            filteredPeopleList.DataSource = people.Where(x => x.YearsExperience > 2).ToList();
        }

        private void allPeopleDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person selectedPerson = (Person)allPeopleDropdown.SelectedItem;

            yearsExperiencePicker.Value = selectedPerson.YearsExperience;
        }

        private void updatePersonButton_Click(object sender, EventArgs e)
        {
            Person selectedPerson = (Person)allPeopleDropdown.SelectedItem;

            selectedPerson.YearsExperience = Convert.ToInt32(yearsExperiencePicker.Value);
            UpdateBindings();
        }

    }
}